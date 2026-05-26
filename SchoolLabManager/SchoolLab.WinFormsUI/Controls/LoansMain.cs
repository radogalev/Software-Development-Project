using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Services.Implementations;
using SchoolLab.Services.Interfaces;
using SchoolLab.WinFormsUI.Dialogs;
using SchoolLab.WinFormsUI.Helpers;

namespace SchoolLab.WinFormsUI.Controls
{
    public partial class LoansMain : UserControl, IDashboardTab
    {
        public LoanItem selectedItem;
        private readonly ILoanService? _loanService;
        private readonly User _currentUser;

        public LoansMain(User current, ILoanService? loanService = null)
        {
            InitializeComponent();
            _loanService = loanService;
            _currentUser = current;
            Load += LoansMain_Load;
        }

        // ReturnSelectedLoanAsync - prompts user for return condition and performs the return operation.
        // Note: we try to use an injected ILoanService when available; otherwise we construct
        // a short-lived LoanService/Repository pair to perform the operation (keeps UI decoupled).
        private async Task ReturnSelectedLoanAsync()
        {
            if (selectedItem == null) return;

            try
            {
                Loan? loan = null;
                if (_loanService != null)
                {
                    loan = await _loanService.GetLoanWithDetailsAsync(selectedItem.LoanId);
                }
                else
                {
                    using var ctx = new SchoolLabDbContext();
                    var repo = new LoanRepository(ctx);
                    loan = await repo.GetLoanWithDetailsAsync(selectedItem.LoanId);
                }

                if (loan == null)
                {
                    MessageBox.Show("Loan not found.");
                    return;
                }
                if (loan.Status == LoanStatus.Returned || loan.Status == LoanStatus.ReturnedLate)
                {
                    MessageBox.Show("Loan already returned.");
                    return;
                }

                var dlg = new ReturnLoadDialog(loan);
                DialogResult res = dlg.ShowDialog();
                if (res != DialogResult.OK)
                    return;

                var input = dlg.Result;
                if (input == null)
                    return;

                bool ok;
                if (_loanService != null)
                {
                    ok = await _loanService.ReturnLoanAsync(selectedItem.LoanId, input.Condition);
                }
                else
                {
                    // Fallback: create short-lived repos+service to perform return.
                    using var ctx2 = new SchoolLabDbContext();
                    var loanRepo = new LoanRepository(ctx2);
                    var assetRepo = new AssetRepository(ctx2);
                    var svc = new LoanService(assetRepo, loanRepo);
                    ok = await svc.ReturnLoanAsync(selectedItem.LoanId, input.Condition);
                }

                if (!ok)
                {
                    MessageBox.Show("Could not return loan. It may have been modified or is not active.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning loan: {ex.Message}");
            }
        }

        private async Task AddItemAsync()
        {
            try
            {
                var dlg = new AddLoanDialog();
                DialogResult res = dlg.ShowDialog();
                if (res != DialogResult.OK) return;

                var input = dlg.Result;
                if (input == null) return;

                using var ctx = new SchoolLabDbContext();
                Loan newLoan = new Loan
                {
                    AssetId = input.BorrowedAsset.Id,
                    BorrowerId = input.Borrower.Id,
                    LeaserId = _currentUser.Id,
                    DueDate = input.DueDate,
                    Status = LoanStatus.Active,
                    BorrowDate = DateTime.Now
                };

                Loan? created = null;
                if (_loanService != null)
                {
                    created = await _loanService.CreateLoanAsync(newLoan);
                }
                else
                {
                    // Fallback: use repositories/services instead of raw DbContext write
                    var loanRepo = new LoanRepository(ctx);
                    var assetRepo = new AssetRepository(ctx);
                    var svc = new LoanService(assetRepo, loanRepo);
                    created = await svc.CreateLoanAsync(newLoan);
                }

                if (created == null)
                {
                    MessageBox.Show("Could not create loan. Asset may be unavailable.");
                    return;
                }

                await LoadAllLoansAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding loan: {ex.Message}\n{ex.InnerException}");
            }
        }

        public async void ActionOne()
        {
            await AddItemAsync();
        }

        public async void ActionTwo()
        {
            await ReturnSelectedLoanAsync();
            await LoadAllLoansAsync();
        }

        private async void LoansMain_Load(object? sender, EventArgs e)
        {
            await LoadAllLoansAsync();
        }

        private async Task LoadAllLoansAsync()
        {
            try
            {
                IEnumerable<Loan> loans;
                if (_loanService != null)
                {
                    loans = await _loanService.GetAllLoansAsync();
                }
                else
                {
                    using var context = new SchoolLabDbContext();
                    loans = await context.Loans
                        .Include(l => l.BorrowedAsset)
                        .Include(l => l.Borrower)
                        .Include(l => l.Leaser)
                        .ToListAsync();
                }

                flowLayoutPanelLoans.Controls.Clear();
                foreach (var l in loans)
                {
                    var item = new LoanItem();
                    item.Bind(l);
                    item.Click += LoanItem_Click;
                    flowLayoutPanelLoans.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading loans: {ex.Message}");
            }
        }

        private void LoanItem_Click(object? sender, EventArgs e)
        {
            if (sender is LoanItem li)
            {
                if (selectedItem != null) selectedItem.Selected = false;
                selectedItem = li;
                selectedItem.Selected = true;
            }
        }
    }
}
