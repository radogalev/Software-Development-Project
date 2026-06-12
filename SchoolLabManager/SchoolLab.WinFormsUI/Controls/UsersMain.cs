using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Services.Interfaces;
using SchoolLab.WinFormsUI.Dialogs;
using SchoolLab.WinFormsUI.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLab.WinFormsUI.Controls
{
    public partial class UsersMain : UserControl, IDashboardTab
    {
        public UserItem selectedItem;
        private readonly IAuthService? _authService;
        private readonly IUserService? _userService;

        public UsersMain(IAuthService? authService = null, IUserService? userService = null)
        {
            InitializeComponent();
            _authService = authService;
            _userService = userService;
            Load += UsersMain_Load;
        }

        private async Task DeleteSelectedItemAsync()
        {
            if (selectedItem == null) return;

            try
            {
                bool deleted;
                if (_userService != null)
                {
                    deleted = await _userService.DeleteUserAsync(selectedItem.UserId);
                }
                else
                {
                    // Fallback: should not be hit when DI is wired correctly
                    MessageBox.Show("User service unavailable.");
                    return;
                }

                if (deleted)
                {
                    MessageBox.Show("User deleted.");
                    selectedItem.Parent?.Controls.Remove(selectedItem);
                    selectedItem = null;
                }
                else
                {
                    MessageBox.Show("Could not delete user. It may have related records or doesn't exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}");
            }
        }

        private async Task ChangeSelectedUserRoleAsync()
        {
            if (selectedItem == null) return;
            if (_userService == null)
            {
                MessageBox.Show("User service unavailable.");
                return;
            }

            try
            {
                User? user = await _userService.GetByIdAsync(selectedItem.UserId);
                if (user == null)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                var dlg = new ChangeUserRoleDialog(user.Role);
                DialogResult res = dlg.ShowDialog();
                if (res != DialogResult.OK) return;

                bool ok = await _userService.ChangeUserRoleAsync(selectedItem.UserId, dlg.SelectedRole);
                if (!ok)
                {
                    MessageBox.Show("Could not change user role.");
                    return;
                }

                await LoadAllUsersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing user role: {ex.Message}\n{ex.InnerException}");
            }
        }

        public async void ActionOne()
        {
            await ChangeSelectedUserRoleAsync();
        }

        public async void ActionTwo()
        {
            await DeleteSelectedItemAsync();
        }

        private async void UsersMain_Load(object? sender, EventArgs e)
        {
            await LoadAllUsersAsync();
        }

        private async Task LoadAllUsersAsync()
        {
            try
            {
                IEnumerable<User> users;
                if (_userService != null)
                {
                    users = await _userService.GetAllUsersAsync();
                }
                else
                {
                    MessageBox.Show("User service unavailable.");
                    return;
                }

                flowLayoutPanelAdministrators.Controls.Clear();
                flowLayoutPanelLabAssistants.Controls.Clear();
                flowLayoutPanelViewers.Controls.Clear();

                foreach (var u in users)
                {
                    var item = new UserItem();
                    item.Bind(u);
                    item.Click += UserItem_Click;
                    GetRolePanel(u.Role).Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }
        }

        private void UserItem_Click(object? sender, EventArgs e)
        {
            if (sender is UserItem ui)
            {
                if (selectedItem != null) selectedItem.Selected = false;
                selectedItem = ui;
                selectedItem.Selected = true;
            }
        }

        private FlowLayoutPanel GetRolePanel(UserRole role)
        {
            return role switch
            {
                UserRole.Administrator => flowLayoutPanelAdministrators,
                UserRole.Viewer => flowLayoutPanelViewers,
                _ => flowLayoutPanelLabAssistants
            };
        }
    }
}
