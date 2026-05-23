using SchoolLab.Core.Models;
using System.Threading.Tasks;

namespace SchoolLab.Data.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        // Find user by username (for login)
        Task<User?> GetByUsernameAsync(string username);
    }
}