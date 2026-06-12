using Microsoft.Extensions.DependencyInjection;
using SchoolLab.Core.Models;
using SchoolLab.Services.Interfaces;
using SchoolLab.WinFormsUI.Forms;

namespace SchoolLab.WinFormsUI
{
    public partial class LoginForm : Form
    {

        private readonly IAuthService _authService;
        private readonly IServiceProvider _provider;
        public LoginForm(IAuthService authService, IServiceProvider provider)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            lblError.ForeColor = Color.Red;

            _authService = authService;
            _provider = provider;
        }

        private async void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text;
            string password = password_txt.Text;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Visible = true;
                return;
            }


            User? User = await _authService.LoginAsync(username, password);
            if (User == null)
            {
                lblError.Visible = true;
                return;
            }

            lblError.Visible = false;

            var dashboard = _provider.GetRequiredService<MainDashboard>();
            dashboard.SetCurrentUser(User);

            this.Hide();
            DialogResult dashboardResult = dashboard.ShowDialog(this);

            if (dashboardResult == DialogResult.Retry)
            {
                password_txt.Clear();
                username_txt.Clear();
                username_txt.Focus();
                this.Show();
                return;
            }

            this.Close();

        }

        private void showPass_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass_chk.Checked)
            {
                password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                password_txt.UseSystemPasswordChar = true;
            }
        }
    }
}
