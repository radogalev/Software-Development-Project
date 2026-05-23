using SchoolLab.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Services.Interfaces
{
    public interface IReportService
    {
        // Overdue loans report
        Task<IEnumerable<Loan>> GetOverdueLoansReportAsync();

        // Loans by person report
        Task<IEnumerable<Loan>> GetLoansByPersonReportAsync(int personId);

        // Most borrowed assets (top N)
        Task<IEnumerable<Asset>> GetMostBorrowedAssetsAsync(int topCount = 10);

        // Assets by location report
        Task<IEnumerable<Asset>> GetAssetsByLocationReportAsync(int locationId);

        // Damage reports for an asset
        Task<IEnumerable<DamageReport>> GetDamageReportsByAssetAsync(int assetId);

        // People with most overdue loans
        Task<Dictionary<User, int>> GetPeopleWithMostOverdueLoansAsync(int topCount = 10);
    }
}