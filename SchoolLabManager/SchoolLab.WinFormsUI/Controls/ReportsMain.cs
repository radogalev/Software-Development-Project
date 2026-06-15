using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Services.Interfaces;
using SchoolLab.WinFormsUI.Dialogs;
using SchoolLab.WinFormsUI.Helpers;

namespace SchoolLab.WinFormsUI.Controls
{
public partial class ReportsMain : UserControl, SchoolLab.WinFormsUI.Helpers.IDashboardTab
    {
        private const string ReportOverdueByDays = "Overdue loans by days";
        private const string ReportMostBorrowedAssets = "Most borrowed assets";
        private const string ReportPeopleWithMostOverdue = "People with most overdue loans";
        private const string ReportOverdueLoans = "Overdue loans";
        private const string ReportLoansByPerson = "Loans by person";
        private const string ReportAssetsByLocation = "Assets by location";
        private const string ReportAssetsWithFrequentDamage = "Assets with frequent damages";

        public ReportItem selectedItem;
        private readonly IReportService? _reportService;
        private readonly User _currentUser;
        private bool _statisticsReady;

        public ReportsMain(User currentUser, IReportService? reportService = null)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _reportService = reportService;
            InitializeStatisticsControls();
            Load += ReportsMain_Load;
        }

        private async Task DeleteSelectedItemAsync()
        {
            if (selectedItem == null) return;

            try
            {
                bool deleted;
                if (_reportService != null)
                {
                    deleted = await _reportService.DeleteReportAsync(selectedItem.ReportId);
                }
                else
                {
                    using var ctx = new SchoolLabDbContext();
                    var repo = new DamageReportRepository(ctx);
                    var r = await repo.GetByIdAsync(selectedItem.ReportId);
                    if (r == null) { deleted = false; }
                    else
                    {
                        ctx.DamageReports.Remove(r);
                        await ctx.SaveChangesAsync();
                        deleted = true;
                    }
                }

                if (deleted)
                {
                    MessageBox.Show("Report deleted.");
                    flowLayoutPanelReports.Controls.Remove(selectedItem);
                    selectedItem = null;
                }
                else
                {
                    MessageBox.Show("Could not delete report. It may not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting report: {ex.Message}");
            }
        }

        private async Task AddItemAsync()
        {
            try
            {
                var dlg = new AddDamageReportDialog();
                DialogResult res = dlg.ShowDialog();
                if (res != DialogResult.OK) return;

                var input = dlg.Result;
                if (input == null) return;

                DamageReport newReport = new DamageReport
                {
                    AssetId = input.AssetId,
                    Description = input.Description,
                    DateReported = input.DateReported,
                    ReportedById = input.ReportedById,
                    RepairedById = input.RepairedById,
                    LoanId = input.LoanId,
                };

                DamageReport? created = null;
                if (_reportService != null)
                {
                    created = await _reportService.CreateReportAsync(newReport);
                }
                else
                {
                    using var ctx = new SchoolLabDbContext();
                    await ctx.DamageReports.AddAsync(newReport);
                    await ctx.SaveChangesAsync();
                    created = newReport;
                }

                if (created == null)
                {
                    MessageBox.Show("Could not create report.");
                    return;
                }

                await LoadAllReportsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding report: {ex.Message}\n{ex.InnerException}");
            }
        }


        public async void ActionOne()
        {
            await AddItemAsync();
        }

        public async void ActionTwo()
        {
            await DeleteSelectedItemAsync();
        }

        private async void ReportsMain_Load(object? sender, EventArgs e)
        {
            await LoadAllReportsAsync();
            await LoadStatisticsAsync();
        }

        private async Task LoadAllReportsAsync()
        {
            try
            {
                using var context = new SchoolLabDbContext();
                var reports = await context.DamageReports
                    .Include(r => r.BorrowedAsset)
                    .Include(r => r.ReportedBy)
                    .Include(r => r.RepairedBy)
                    .ToListAsync();

                flowLayoutPanelReports.Controls.Clear();
                foreach (var r in reports)
                {
                    var item = new ReportItem(_currentUser);
                    item.Bind(r);
                    item.Click += ReportItem_Click;
                    flowLayoutPanelReports.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reports: {ex.Message}");
            }
        }

        private void ReportItem_Click(object? sender, EventArgs e)
        {
            if (sender is ReportItem ri)
            {
                if (selectedItem != null) selectedItem.Selected = false;
                selectedItem = ri;
                selectedItem.Selected = true;
            }
        }

        private void InitializeStatisticsControls()
        {
            cmbReportType.Items.AddRange(new object[]
            {
                ReportOverdueByDays,
                ReportMostBorrowedAssets,
                ReportPeopleWithMostOverdue,
                ReportOverdueLoans,
                ReportLoansByPerson,
                ReportAssetsByLocation,
                ReportAssetsWithFrequentDamage
            });

            cmbReportType.SelectedIndex = 0;
            _statisticsReady = true;
        }

        private async Task LoadStatisticsAsync()
        {
            if (cmbReportType.SelectedItem is not string selectedReport)
            {
                return;
            }

            try
            {
                await LoadReportFilterAsync(selectedReport);
                await BindSelectedReportAsync(selectedReport);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}");
            }
        }

        private async Task LoadReportFilterAsync(string selectedReport)
        {
            cmbReportFilter.SelectedIndexChanged -= cmbReportFilter_SelectedIndexChanged;
            cmbReportFilter.Items.Clear();
            cmbReportFilter.DisplayMember = nameof(LookupItem.Name);
            cmbReportFilter.ValueMember = nameof(LookupItem.Id);

            bool needsPerson = selectedReport == ReportLoansByPerson;
            bool needsLocation = selectedReport == ReportAssetsByLocation;
            bool needsFilter = needsPerson || needsLocation;

            lblReportFilter.Visible = needsFilter;
            cmbReportFilter.Visible = needsFilter;

            if (!needsFilter)
            {
                cmbReportFilter.SelectedIndexChanged += cmbReportFilter_SelectedIndexChanged;
                return;
            }

            using var context = new SchoolLabDbContext();
            List<LookupItem> items;
            if (needsPerson)
            {
                items = await context.Users
                    .OrderBy(u => u.DisplayName)
                    .Select(u => new LookupItem { Id = u.Id, Name = u.DisplayName + " (" + u.Username + ")" })
                    .ToListAsync();
            }
            else
            {
                items = await context.Locations
                    .OrderBy(l => l.Name)
                    .Select(l => new LookupItem { Id = l.Id, Name = l.Name })
                    .ToListAsync();
            }

            foreach (var item in items)
            {
                cmbReportFilter.Items.Add(item);
            }

            if (cmbReportFilter.Items.Count > 0 && cmbReportFilter.SelectedIndex < 0)
            {
                cmbReportFilter.SelectedIndex = 0;
            }

            cmbReportFilter.SelectedIndexChanged += cmbReportFilter_SelectedIndexChanged;
        }

        private async Task BindSelectedReportAsync(string selectedReport)
        {
            using var context = new SchoolLabDbContext();

            switch (selectedReport)
            {
                case ReportOverdueByDays:
                    await BindOverdueLoansByDaysAsync(context);
                    break;
                case ReportMostBorrowedAssets:
                    await BindMostBorrowedAssetsAsync(context);
                    break;
                case ReportPeopleWithMostOverdue:
                    await BindPeopleWithMostOverdueLoansAsync(context);
                    break;
                case ReportOverdueLoans:
                    await BindOverdueLoansAsync(context);
                    break;
                case ReportLoansByPerson:
                    await BindLoansByPersonAsync(context);
                    break;
                case ReportAssetsByLocation:
                    await BindAssetsByLocationAsync(context);
                    break;
                case ReportAssetsWithFrequentDamage:
                    await BindAssetsWithFrequentDamagesAsync(context);
                    break;
            }
        }

        private async Task BindOverdueLoansByDaysAsync(SchoolLabDbContext context)
        {
            var today = DateTime.Now.Date;
            var rows = (await GetOverdueLoansQuery(context).ToListAsync())
                .Select(l => new
                {
                    Loan = l.Id,
                    Asset = l.BorrowedAsset?.Name ?? "Unknown",
                    Borrower = l.Borrower?.DisplayName ?? "Unknown",
                    Due = l.DueDate.ToString("yyyy-MM-dd"),
                    DaysOverdue = Math.Max(0, (today - l.DueDate.Date).Days),
                    Status = l.Status.ToString()
                })
                .OrderByDescending(x => x.DaysOverdue)
                .ToList();

            dgvStatistics.DataSource = rows;
        }

        private async Task BindMostBorrowedAssetsAsync(SchoolLabDbContext context)
        {
            var loans = await context.Loans
                .Include(l => l.BorrowedAsset)
                .ToListAsync();

            var rows = loans
                .GroupBy(l => new { l.AssetId, Asset = l.BorrowedAsset?.Name ?? "Unknown" })
                .Select(g => new
                {
                    Asset = g.Key.Asset,
                    BorrowCount = g.Count(),
                    ActiveLoans = g.Count(l => l.Status == LoanStatus.Active || l.Status == LoanStatus.Overdue),
                    LateReturns = g.Count(l => l.Status == LoanStatus.ReturnedLate)
                })
                .OrderByDescending(x => x.BorrowCount)
                .ThenBy(x => x.Asset)
                .Take(10)
                .ToList();

            dgvStatistics.DataSource = rows;
        }

        private async Task BindPeopleWithMostOverdueLoansAsync(SchoolLabDbContext context)
        {
            var overdueLoans = await context.Loans
                .Include(l => l.Borrower)
                .Where(l => l.Status == LoanStatus.Overdue || l.Status == LoanStatus.ReturnedLate || (l.Status == LoanStatus.Active && l.DueDate < DateTime.Now))
                .ToListAsync();

            var rows = overdueLoans
                .GroupBy(l => new { l.BorrowerId, Borrower = l.Borrower?.DisplayName ?? "Unknown" })
                .Select(g => new
                {
                    Borrower = g.Key.Borrower,
                    OverdueCount = g.Count(),
                    CurrentlyOverdue = g.Count(l => l.Status == LoanStatus.Overdue || (l.Status == LoanStatus.Active && l.DueDate < DateTime.Now)),
                    ReturnedLate = g.Count(l => l.Status == LoanStatus.ReturnedLate)
                })
                .OrderByDescending(x => x.OverdueCount)
                .ThenBy(x => x.Borrower)
                .Take(10)
                .ToList();

            dgvStatistics.DataSource = rows;
        }

        private async Task BindOverdueLoansAsync(SchoolLabDbContext context)
        {
            var loans = await GetOverdueLoansQuery(context).ToListAsync();

            var rows = loans
                .Select(l => new
                {
                    Loan = l.Id,
                    Asset = l.BorrowedAsset?.Name ?? "Unknown",
                    Borrower = l.Borrower?.DisplayName ?? "Unknown",
                    Borrowed = l.BorrowDate.ToString("yyyy-MM-dd"),
                    Due = l.DueDate.ToString("yyyy-MM-dd"),
                    Status = l.Status.ToString()
                })
                .ToList();

            dgvStatistics.DataSource = rows;
        }

        private async Task BindLoansByPersonAsync(SchoolLabDbContext context)
        {
            if (cmbReportFilter.SelectedItem is not LookupItem person)
            {
                dgvStatistics.DataSource = null;
                return;
            }

            var loans = await context.Loans
                .Include(l => l.BorrowedAsset)
                .Where(l => l.BorrowerId == person.Id)
                .OrderByDescending(l => l.BorrowDate)
                .ToListAsync();

            var rows = loans
                .Select(l => new
                {
                    Loan = l.Id,
                    Asset = l.BorrowedAsset?.Name ?? "Unknown",
                    Borrowed = l.BorrowDate.ToString("yyyy-MM-dd"),
                    Due = l.DueDate.ToString("yyyy-MM-dd"),
                    Returned = l.ReturnDate == null ? "" : l.ReturnDate.Value.ToString("yyyy-MM-dd"),
                    Status = l.Status.ToString()
                })
                .ToList();

            dgvStatistics.DataSource = rows;
        }

        private async Task BindAssetsByLocationAsync(SchoolLabDbContext context)
        {
            if (cmbReportFilter.SelectedItem is not LookupItem location)
            {
                dgvStatistics.DataSource = null;
                return;
            }

            var assets = await context.Assets
                .Include(a => a.Category)
                .Where(a => a.LocationId == location.Id)
                .OrderBy(a => a.Name)
                .ToListAsync();

            var rows = assets
                .Select(a => new
                {
                    Asset = a.Name,
                    Category = a.Category?.Name ?? "Unknown",
                    Serial = a.SerialNumber,
                    Status = a.Status.ToString(),
                    Condition = a.Condition.ToString()
                })
                .ToList();

            dgvStatistics.DataSource = rows;
        }

        private async Task BindAssetsWithFrequentDamagesAsync(SchoolLabDbContext context)
        {
            var reports = await context.DamageReports
                .Include(r => r.BorrowedAsset)
                .ToListAsync();

            var rows = reports
                .GroupBy(r => new { r.AssetId, Asset = r.BorrowedAsset?.Name ?? "Unknown" })
                .Select(g => new
                {
                    Asset = g.Key.Asset,
                    DamageReports = g.Count(),
                    LastReported = g.Max(r => r.DateReported).ToString("yyyy-MM-dd")
                })
                .OrderByDescending(x => x.DamageReports)
                .ThenBy(x => x.Asset)
                .ToList();

            dgvStatistics.DataSource = rows;
        }

        private static IQueryable<Loan> GetOverdueLoansQuery(SchoolLabDbContext context)
        {
            return context.Loans
                .Include(l => l.BorrowedAsset)
                .Include(l => l.Borrower)
                .Where(l => l.Status == LoanStatus.Overdue || (l.Status == LoanStatus.Active && l.DueDate < DateTime.Now))
                .OrderBy(l => l.DueDate);
        }

        private async void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_statisticsReady) return;
            await LoadStatisticsAsync();
        }

        private async void cmbReportFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_statisticsReady) return;
            if (cmbReportType.SelectedItem is string selectedReport)
            {
                await BindSelectedReportAsync(selectedReport);
            }
        }

        private async void btnRefreshReport_Click(object sender, EventArgs e)
        {
            await LoadStatisticsAsync();
        }
    }
}
