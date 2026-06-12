using SchoolLab.Core.Enums;

namespace SchoolLab.WinFormsUI.Dialogs
{
    public partial class AddUserDialog : Form
    {
        public AddUserInput? Result { get; private set; }
        private readonly UserRole? _fixedRole;

        public AddUserDialog(UserRole? fixedRole = null, string saveButtonText = "Save")
        {
            InitializeComponent();
            _fixedRole = fixedRole;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            AcceptButton = Save_btn;
            CancelButton = Cancel_btn;
            Save_btn.Text = saveButtonText;
            UserRols_cbox.DataSource = Enum.GetValues(typeof(UserRole));
            UserRols_cbox.SelectedItem = fixedRole ?? UserRole.Administrator;

            if (fixedRole != null)
            {
                label1.Visible = false;
                UserRols_cbox.Visible = false;
                Save_btn.Location = new Point(Save_btn.Location.X, 209);
                Cancel_btn.Location = new Point(Cancel_btn.Location.X, 209);
                ClientSize = new Size(ClientSize.Width, 251);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username_txt.Text))
            {
                MessageBox.Show("Please enter username.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            if (string.IsNullOrWhiteSpace(Fullname_txt.Text))
            {
                MessageBox.Show("Please enter full name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            if (string.IsNullOrWhiteSpace(Password_txt.Text))
            {
                MessageBox.Show("Please enter password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            Result = new AddUserInput
            {
                Username = Username_txt.Text.Trim(),
                FullName = Fullname_txt.Text.Trim(),
                Password = Password_txt.Text.Trim(),
                Role = _fixedRole ?? (UserRole)UserRols_cbox.SelectedItem
            };

            this.DialogResult = DialogResult.OK;
        }
    }

    public class AddUserInput
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
