using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using SchoolLab.Core.Enums;
using System.Text;
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
