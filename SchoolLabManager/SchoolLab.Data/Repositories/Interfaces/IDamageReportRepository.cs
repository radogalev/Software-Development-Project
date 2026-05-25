using SchoolLab.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Data.Repositories.Interfaces
{
    public interface IDamageReportRepository : IRepository<DamageReport>
    {
        Task<IEnumerable<DamageReport>> GetDamageReportsByAssetAsync(int assetId);
        Task<DamageReport> GetDamageReportByIdAsync(int Id);
    }
}