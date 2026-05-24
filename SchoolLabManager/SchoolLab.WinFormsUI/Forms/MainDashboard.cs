using SchoolLab.Core.Models;
using SchoolLab.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SchoolLab.WinFormsUI.Helpers;
using SchoolLab.WinFormsUI.Controls;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Services.Implementations;
using SchoolLab.Services.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace SchoolLab.WinFormsUI.Forms
{
    public partial class MainDashboard : Form
    {
        private readonly User _currentUser;
        public MainDashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            lblWelcomeName.Text = $"Welcome,\n{user.DisplayName}";
            lblWelcomeRole.Text = user.Role.ToString();

            HidePanels();
            btnManageAssets_Click(null, null);
        }
        private void HidePanels()
        {
            if (_currentUser.Role != UserRole.Administrator)
            {
                btnManageUsers.Visible = false;
            }
            if(_currentUser.Role == UserRole.Viewer)
            {
                btnActionOne.Visible = false;
                btnActionTwo.Visible = false;
                btnManageReports.Visible = false;
            }
        }
        private void btnManageAssets_Click(object sender, EventArgs e)
        {
            var ctx = new SchoolLabDbContext();
            var repo = new AssetRepository(ctx);
            IAssetService svc = new AssetService(repo);
            AsssetsMain dsh = new AsssetsMain(_currentUser, svc);
            MainControl_pnl.Controls.Clear();
            MainControl_pnl.Controls.Add(dsh);
            btnActionTwo.Text = "Delete";
        }

        private void btnActionOne_Click(object sender, EventArgs e)
        {
            if (MainControl_pnl.Controls.Count > 0 && MainControl_pnl.Controls[0] is IDashboardTab tab)
            {
                tab.ActionOne();
            }
        }

        private void btnActionTwo_Click_1(object sender, EventArgs e)
        {
            if (MainControl_pnl.Controls.Count > 0 && MainControl_pnl.Controls[0] is IDashboardTab tab)
            {
                tab.ActionTwo();
            }
        }

        // Event handlers wired by designer must use void return type.
        // Changed from Task to async void to match Windows Forms event signature.
        private async void btnManageLoans_Click(object sender, EventArgs e)
        {
            var ctx = new SchoolLabDbContext();
            var repo = new LoanRepository(ctx);
            var repo2 = new AssetRepository(ctx);
            ILoanService svc = new LoanService(repo2, repo);
            await svc.UpdateOverdueLoansAsync();
            LoansMain dsh = new LoansMain(_currentUser, svc);
            MainControl_pnl.Controls.Clear();
            MainControl_pnl.Controls.Add(dsh);
            btnActionTwo.Text = "Return";
        }

        private void btnManageReports_Click(object sender, EventArgs e)
        {
            var ctx = new SchoolLabDbContext();
            var repo = new LoanRepository(ctx);
            var repo2 = new AssetRepository(ctx);
            var repo3 = new DamageReportRepository(ctx);
            IReportService svc = new ReportService(repo, repo2, repo3);
            ReportsMain dsh = new ReportsMain(svc);
            MainControl_pnl.Controls.Clear();
            MainControl_pnl.Controls.Add(dsh);
            btnActionTwo.Text = "Delete";
        }

        private void btnManageUsers_Click_1(object sender, EventArgs e)
        {
            var ctx = new SchoolLabDbContext();
            var repo = new UserRepository(ctx);
            IAuthService svc = new AuthService(repo);
            UsersMain dsh = new UsersMain(svc);
            MainControl_pnl.Controls.Clear();
            MainControl_pnl.Controls.Add(dsh);
            btnActionTwo.Text = "Delete";
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
