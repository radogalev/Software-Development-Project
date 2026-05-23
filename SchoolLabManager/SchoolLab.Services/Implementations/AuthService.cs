using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Repositories.Interfaces;
using SchoolLab.Services.Helpers;
using SchoolLab.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLab.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepo;
        public AuthService (IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }

        public async Task<User?> LoginAsync(string username, string password)
        {
            User? user = await _userRepo.GetByUsernameAsync(username);
            if (user == null)
            {
                return null;
            }

            if (PasswordHasher.VerifyPassword(password, user.PasswordHash))
            {
                return user;  
            }

            return null;
        }
        public async Task<bool> RegisterUserAsync(User user, string password)
        {
            var existing = await _userRepo.GetByUsernameAsync(user.Username);
            if (existing != null)
            {
                return false; 
            }

            user.PasswordHash = PasswordHasher.HashPassword(password);
            user.TimeOfRegistration = DateTime.Now;

            await _userRepo.AddAsync(user);
            await _userRepo.SaveChangesAsync();
            return true;
        }


        public async Task<bool> ChangePasswordAsync(int userId, string oldPassword, string newPassword)
        {
            User? user = await _userRepo.GetByIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            if (PasswordHasher.VerifyPassword(oldPassword, user.PasswordHash))
            {
                user.PasswordHash = PasswordHasher.HashPassword(newPassword);
                _userRepo.Update(user);
                await _userRepo.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
