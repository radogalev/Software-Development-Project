using SchoolLab.Core.Enums;
using SchoolLab.Data.Context;

namespace SchoolLab.WinFormsUI.Dialogs
{
    public partial class EditDamageReportDialog : Form
    {
        public int? SelectedRepairedById { get; private set; }

        public EditDamageReportDialog(string title, string message, int? repairedById)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            AcceptButton = Save_btn;
            CancelButton = Cancel_btn;
            Text = title;
            Info_lbl.Text = message;

            LoadRepairUsers(repairedById);
        }

        private void LoadRepairUsers(int? repairedById)
        {
            using var ctx = new SchoolLabDbContext();
            var repairUsers = ctx.Users
                .Where(u => u.Role == UserRole.Administrator || u.Role == UserRole.LabAssistant)
                .OrderBy(u => u.Username)
                .Select(u => new RepairUserOption { Id = u.Id, Name = u.Username })
                .ToList();

            repairUsers.Insert(0, new RepairUserOption { Id = 0, Name = "Not repaired" });

            repairedBy_cbox.DataSource = repairUsers;
            repairedBy_cbox.DisplayMember = "Name";
            repairedBy_cbox.ValueMember = "Id";
            repairedBy_cbox.SelectedValue = repairedById ?? 0;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (repairedBy_cbox.SelectedItem is RepairUserOption selected)
            {
                SelectedRepairedById = selected.Id == 0 ? null : selected.Id;
            }

            DialogResult = DialogResult.OK;
        }

        private class RepairUserOption
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        }
    }
}
