using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Services.Implementations;
using SchoolLab.WinFormsUI.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using SchoolLab.Services.Interfaces;

namespace SchoolLab.WinFormsUI.Controls
{
    public partial class UsersMain : UserControl, SchoolLab.WinFormsUI.Helpers.IDashboardTab
    {
        public UserItem selectedItem;
        private readonly IAuthService? _authService;

        public UsersMain(IAuthService? authService = null)
        {
            InitializeComponent();
            _authService = authService;
            Load += UsersMain_Load;
        }

        private async Task DeleteSelectedItemAsync()
        {
            if (selectedItem == null) return;

            try
            {
                bool deleted;
                using var ctx = new SchoolLabDbContext();
                var repo = new UserRepository(ctx);
                var user = await repo.GetByIdAsync(selectedItem.UserId);
                if (user == null) { deleted = false; }
                else
                {
                    ctx.Users.Remove(user);
                    await ctx.SaveChangesAsync();
                    deleted = true;
                }

                if (deleted)
                {
                    MessageBox.Show("User deleted.");
                    flowLayoutPanelUsers.Controls.Remove(selectedItem);
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

        private async Task AddItemAsync()
        {
            try
            {
                var dlg = new AddUserDialog();
                DialogResult res = dlg.ShowDialog();
                if (res != DialogResult.OK) return;

                var input = dlg.Result;
                if (input == null) return;

                User newUser = new User
                {
                    Username = input.Username,
                    DisplayName = input.FullName,
                    PasswordHash = input.Password,
                    Role = input.Role,

                };

                bool ok;
                if (_authService != null)
                {
                    ok = await _authService.RegisterUserAsync(newUser, input.Password);
                }
                else
                {
                    using var ctx = new SchoolLabDbContext();
                    await ctx.Users.AddAsync(newUser);
                    await ctx.SaveChangesAsync();
                    ok = true;
                }

                if (!ok)
                {
                    MessageBox.Show("Could not create user.");
                    return;
                }

                await LoadAllUsersAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}\n{ex.InnerException}");
            }
        }

        public async void ActionOne()
        {
            await AddItemAsync();
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
                using var context = new SchoolLabDbContext();
                var users = await context.Users.ToListAsync();

                flowLayoutPanelUsers.Controls.Clear();
                foreach (var u in users)
                {
                    var item = new UserItem();
                    item.Bind(u);
                    item.Click += UserItem_Click;
                    flowLayoutPanelUsers.Controls.Add(item);
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
    }
}
