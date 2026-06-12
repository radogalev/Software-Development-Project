using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.WinFormsUI.Dialogs;
using System.ComponentModel;

namespace SchoolLab.WinFormsUI.Controls
{
    public partial class LoanItem : UserControl
    {
        public LoanItem()
        {
            InitializeComponent();
            lblName.Click += (s, e) => this.OnClick(e);
            lblName.DoubleClick += (s, e) => this.OnDoubleClick(e);
        }

        public int LoanId { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Selected
        {
            get { return this.BackColor == Color.DarkTurquoise; }
            set { this.BackColor = value ? Color.DarkTurquoise : Color.PaleTurquoise; }
        }

        public void Bind(Loan loan)
        {
            if (loan == null) return;
            LoanId = loan.Id;
            lblName.Text = $"Loan #{loan.Id} - {(loan.BorrowedAsset?.Name ?? "Asset")}\n";
            if (loan.Status is LoanStatus.Returned or LoanStatus.ReturnedLate)
            {
                lblName.Text += $"Loan was {loan.Status}\n";
            }
            else
            {
                lblName.Text += $"Due date: {loan.DueDate.Date}";
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            try
            {
                using var context = new SchoolLabDbContext();
                var loan = context.Loans
                    .Include(x => x.BorrowedAsset)
                    .Include(x => x.Borrower)
                    .Include(x => x.Leaser)
                    .FirstOrDefault(x => x.Id == LoanId);

                if (loan == null)
                {
                    MessageBox.Show(this, "Loan not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string message =
                    $"Loan Id: {loan.Id}\n" +
                    $"Asset: {loan.BorrowedAsset?.Name}\n" +
                    $"Borrower: {loan.Borrower?.Username}\n" +
                    $"Due: {loan.DueDate:yyyy-MM-dd}\n" +
                    $"Status: {loan.Status}\n";

                var dlg = new ShowInfoDialog($"Loan #{loan.Id}", message);
                dlg.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "An error occurred while showing loan details:\n" + ex.Message + "\n" + ex.InnerException, "Error\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoanItem_Load(object sender, EventArgs e)
        {

        }
    }
}
