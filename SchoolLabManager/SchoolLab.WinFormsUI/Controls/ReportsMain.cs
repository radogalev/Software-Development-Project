using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Services.Interfaces;
using SchoolLab.WinFormsUI.Dialogs;

namespace SchoolLab.WinFormsUI.Controls
{
public partial class ReportsMain : UserControl, SchoolLab.WinFormsUI.Helpers.IDashboardTab
    {
        public ReportItem selectedItem;
        private readonly IReportService? _reportService;
        private readonly User _currentUser;

        public ReportsMain(User currentUser, IReportService? reportService = null)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _reportService = reportService;
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
    }
}
