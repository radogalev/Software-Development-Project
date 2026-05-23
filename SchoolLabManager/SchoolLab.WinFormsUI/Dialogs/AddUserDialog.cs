using SchoolLab.Core.Enums;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolLab.WinFormsUI.Dialogs
{
    public partial class AddUserDialog : Form
    {
        public AddUserInput? Result { get; private set; }

        public AddUserDialog()
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
            UserRols_cbox.SelectedIndex = 0;
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
                Role = (UserRole)UserRols_cbox.SelectedItem
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
