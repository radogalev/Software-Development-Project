using SchoolLab.Core.Enums;

namespace SchoolLab.WinFormsUI.Dialogs
{
    public partial class ChangeUserRoleDialog : Form
    {
        public UserRole SelectedRole { get; private set; }

        public ChangeUserRoleDialog(UserRole currentRole)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            AcceptButton = Save_btn;
            CancelButton = Cancel_btn;

            UserRols_cbox.DataSource = Enum.GetValues(typeof(UserRole));
            UserRols_cbox.SelectedItem = currentRole;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            SelectedRole = (UserRole)UserRols_cbox.SelectedItem;
            DialogResult = DialogResult.OK;
        }
    }
}
