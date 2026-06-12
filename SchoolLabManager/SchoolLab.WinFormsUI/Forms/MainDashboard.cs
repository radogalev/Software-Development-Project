using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Services.Interfaces;
using SchoolLab.WinFormsUI.Controls;
using SchoolLab.WinFormsUI.Helpers;

namespace SchoolLab.WinFormsUI.Forms
{
    public partial class MainDashboard : Form
    {
        private User _currentUser;
        private IAssetService _assetService;
        private ILoanService _loanService;
        private IReportService _reportService;
        private IAuthService _authService;
        private IUserService _userService;
        public MainDashboard(IAssetService assetService, ILoanService loanService, IReportService reportService, IAuthService authService, IUserService userService)
        {
            InitializeComponent();
            _assetService = assetService;
            _loanService = loanService;
            _reportService = reportService;
            _authService = authService;
            _userService = userService;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;



        }

        public void SetCurrentUser(User user)
        {
            _currentUser = user;
            lblWelcomeName.Text = $"Welcome, {user.DisplayName}";
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
            if (_currentUser.Role == UserRole.Viewer)
            {
                btnActionOne.Visible = false;
                btnActionTwo.Visible = false;
                btnManageReports.Visible = false;
            }
        }
        private void btnManageAssets_Click(object sender, EventArgs e)
        {

            var assetsTab = new AsssetsMain(_currentUser, _assetService);
            MainControl_pnl.Controls.Clear();
            MainControl_pnl.Controls.Add(assetsTab);
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

        private async void btnManageLoans_Click(object sender, EventArgs e)
        {
            await _loanService.UpdateOverdueLoansAsync();
            var loansTab = new LoansMain(_currentUser, _loanService);
            MainControl_pnl.Controls.Clear();
            MainControl_pnl.Controls.Add(loansTab);
            btnActionTwo.Text = "Return";
        }

        private void btnManageReports_Click(object sender, EventArgs e)
        {
            var reportsTab = new ReportsMain(_reportService);
            MainControl_pnl.Controls.Clear();
            MainControl_pnl.Controls.Add(reportsTab);
            btnActionTwo.Text = "Delete";
        }

        private void btnManageUsers_Click_1(object sender, EventArgs e)
        {
            var usersTab = new UsersMain(_authService, _userService);
            MainControl_pnl.Controls.Clear();
            MainControl_pnl.Controls.Add(usersTab);
            btnActionTwo.Text = "Delete";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
