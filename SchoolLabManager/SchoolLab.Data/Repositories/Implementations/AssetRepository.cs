using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLab.Data.Repositories.Implementations
{
    public class AssetRepository : Repository<Asset>, IAssetRepository
    {
        public AssetRepository(SchoolLabDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Asset>> GetAssetsByStatusAsync(AssetStatus status)
        {
            return await _dbSet.Where(x => x.Status == status).ToListAsync();
        }
        public async Task<IEnumerable<Asset>> GetAssetsByLocationAsync(int locationId)
        {
            return await _dbSet.Where(x => x.LocationId == locationId).ToListAsync();
        }
        public async Task<IEnumerable<Asset>> GetAssetsByCategoryAsync(int categoryId)
        {
            return await _dbSet.Where(x => x.CategoryId == categoryId).ToListAsync();
        }
        public async Task<Asset?> GetAssetWithDetailsAsync(int id)
        {
            return await _dbSet
                .Include(x => x.Category)
                .Include(x =>x.Loans)
                .Include(x => x.StoredLocation)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Asset>> GetAllWithDetailsAsync()
        {
            return await _dbSet
                .Include(x => x.Category)
                .Include(x => x.StoredLocation)
                .Include(x => x.Loans)
                .Include(x => x.DamageReports)
                .ToListAsync();
        }
    }
}
