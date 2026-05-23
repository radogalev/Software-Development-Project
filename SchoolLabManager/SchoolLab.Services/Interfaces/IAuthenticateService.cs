using SchoolLab.Core.Models;
using System.Threading.Tasks;

namespace SchoolLab.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User?> LoginAsync(string username, string password);
        Task<bool> RegisterUserAsync(User user, string password);
        Task<bool> ChangePasswordAsync(int userId, string oldPassword, string newPassword);
    }
}