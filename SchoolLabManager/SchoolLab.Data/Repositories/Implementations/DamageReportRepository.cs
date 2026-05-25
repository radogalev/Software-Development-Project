using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolLab.Data.Repositories.Implementations
{
    public class DamageReportRepository : Repository<DamageReport>, IDamageReportRepository
    {
        public DamageReportRepository(SchoolLabDbContext context) : base(context) { }
        public async Task<IEnumerable<DamageReport>> GetDamageReportsByAssetAsync(int assetId)
        {
            return await _dbSet.Where(dr => dr.AssetId == assetId).ToListAsync();
        }
        public async Task<DamageReport> GetDamageReportByIdAsync(int Id)
        {
            return await _dbSet.FirstOrDefaultAsync(dr => dr.Id == Id);
        }
    }
}
