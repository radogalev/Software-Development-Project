using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace SchoolLab.Data.Repositories.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SchoolLabDbContext context) : base(context) { }
        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Username == username);
        }

    }
}
