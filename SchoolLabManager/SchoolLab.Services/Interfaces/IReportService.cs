using SchoolLab.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Services.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<Loan>> GetOverdueLoansReportAsync();

        Task<IEnumerable<Loan>> GetLoansByPersonReportAsync(int personId);

        Task<IEnumerable<Asset>> GetMostBorrowedAssetsAsync(int topCount = 10);

        Task<IEnumerable<Asset>> GetAssetsByLocationReportAsync(int locationId);

        Task<IEnumerable<DamageReport>> GetDamageReportsByAssetAsync(int assetId);
        Task<DamageReport> GetDamageReportByIdAsync(int Id);

        Task<Dictionary<User, int>> GetPeopleWithMostOverdueLoansAsync(int topCount = 10);

        Task<bool> DeleteReportAsync(int reportId);

        Task<IEnumerable<DamageReport>> GetAllReportsAsync();

        Task<DamageReport> CreateReportAsync(DamageReport report);

    }
}