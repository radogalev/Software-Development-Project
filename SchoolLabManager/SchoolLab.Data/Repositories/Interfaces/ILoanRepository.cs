using SchoolLab.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Data.Repositories.Interfaces
{
    public interface ILoanRepository : IRepository<Loan>
    {
        Task<IEnumerable<Loan>> GetActiveLoansAsync();

        Task<IEnumerable<Loan>> GetOverdueLoansAsync();

        Task<IEnumerable<Loan>> GetLoansByPersonAsync(int personId);

        Task<IEnumerable<Loan>> GetLoansByAssetAsync(int assetId);

        Task<Loan?> GetLoanWithDetailsAsync(int id);
        Task<IEnumerable<Loan>> GetAllWithDetailsAsync();
    }
}