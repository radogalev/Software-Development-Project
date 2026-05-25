using Microsoft.EntityFrameworkCore;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Data.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly SchoolLabDbContext _context;
        protected readonly DbSet<T> _dbSet;


        public Repository(SchoolLabDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        // Get all records from the table
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        // Get single record by ID
        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        // Add new record (doesn't save yet - call SaveChangesAsync after)
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        // Update existing record
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        // Delete record
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        // Save all changes to database
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
