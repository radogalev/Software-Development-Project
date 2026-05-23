using SchoolLab.WinFormsUI.Helpers;
using SchoolLab.Data.Context;
using System;
using System.Linq;
using System.Windows.Forms;
using SchoolLab.Core.Enums;

namespace SchoolLab.WinFormsUI.Dialogs
{
    public partial class AddLoanDialog : Form
    {
        public LoanInputResult? Result { get; private set; }

        public AddLoanDialog()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            AcceptButton = Save_btn;
            CancelButton = Cancel_btn;

            try
            {
                var ctx = new SchoolLabDbContext();
                var assets = ctx.Assets.OrderBy(a => a.Name).Select(a => new LookupItem { Id = a.Id, Name = a.Name }).ToList();
                var users = ctx.Users.Where(u => u.Role == UserRole.Viewer).OrderBy(u => u.Username).Select(u => new LookupItem { Id = u.Id,Name= u.Username}).ToList();

                Asset_cbox.DataSource = assets;
                Asset_cbox.DisplayMember = "Name";
                Asset_cbox.ValueMember = "Id";
                Asset_cbox.SelectedIndex = -1;

                Borrower_cbox.DataSource = users;
                Borrower_cbox.DisplayMember = "Name";
                Borrower_cbox.ValueMember = "Id";
                Borrower_cbox.SelectedIndex = -1;
            }
            catch { }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Asset_cbox.SelectedValue == null || Borrower_cbox.SelectedValue == null)
            {
                MessageBox.Show("Please select asset and borrower.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            var ctx = new SchoolLabDbContext();

            int? selectedAssetId = Asset_cbox.SelectedValue == null
            ? null
            : (int?)Convert.ToInt32(Asset_cbox.SelectedValue);

            int? selectedUserId = Borrower_cbox.SelectedValue == null
            ? null
            : (int?)Convert.ToInt32(Borrower_cbox.SelectedValue);

            Result = new LoanInputResult
            {
                BorrowedAsset = ctx.Assets.Where(a => a.Id == selectedAssetId).First(),
                Borrower = ctx.Users.Where(u => u.Id == selectedUserId).First(),
                DueDate = DueDate_pick.Value.Date
            };
            this.DialogResult = DialogResult.OK;
        }
    }

}
