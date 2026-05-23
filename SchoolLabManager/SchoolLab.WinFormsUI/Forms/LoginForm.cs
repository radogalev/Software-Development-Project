using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SchoolLab.Core.Models;
using SchoolLab.Services.Interfaces;
using SchoolLab.Services.Implementations;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Data.Context;
using SchoolLab.Services.Helpers;
using Microsoft.IdentityModel.Tokens;
using SchoolLab.WinFormsUI.Forms;
using SchoolLab.Data.Helpers;

namespace SchoolLab.WinFormsUI
{
    public partial class LoginForm : Form
    {

        private readonly IAuthService _authService;
        public LoginForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            lblError.ForeColor = Color.Red;

            var context = new SchoolLabDbContext();
            var userRepo = new UserRepository(context);
            _authService = new AuthService(userRepo);
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

            MainDashboard dashboard = new MainDashboard(User);
            this.Hide();
            dashboard.ShowDialog();
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
