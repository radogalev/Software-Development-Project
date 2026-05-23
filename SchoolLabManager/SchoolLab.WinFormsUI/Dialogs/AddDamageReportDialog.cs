using System;
using System.Windows.Forms;
using SchoolLab.Data.Context;

namespace SchoolLab.WinFormsUI.Dialogs
{
    public partial class AddDamageReportDialog : Form
    {
        public AddDamageReportInput? Result { get; private set; }

        public AddDamageReportDialog()
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
                var assets = ctx.Assets.OrderBy(a => a.Name).ToList();
                var users = ctx.Users.OrderBy(u => u.Username).ToList();

                Asset_cbox.DataSource = assets;
                Asset_cbox.DisplayMember = "Name";
                Asset_cbox.ValueMember = "Id";
                Asset_cbox.SelectedIndex = -1;

                ReportedBy_cbox.DataSource = users;
                ReportedBy_cbox.DisplayMember = "Username";
                ReportedBy_cbox.ValueMember = "Id";
                ReportedBy_cbox.SelectedIndex = -1;
            }
            catch { }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Asset_cbox.SelectedValue == null || ReportedBy_cbox.SelectedValue == null)
            {
                MessageBox.Show("Please select asset and reporter.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            Result = new AddDamageReportInput
            {
                AssetId = Convert.ToInt32(Asset_cbox.SelectedValue),
                ReportedById = Convert.ToInt32(ReportedBy_cbox.SelectedValue),
                Description = Description_txt.Text.Trim(),
                DateReported = Date_pick.Value.Date
            };
            this.DialogResult = DialogResult.OK;
        }
    }

    public class AddDamageReportInput
    {
        public int AssetId { get; set; }
        public int ReportedById { get; set; }
        public string Description { get; set; }
        public DateTime DateReported { get; set; }
    }
}
