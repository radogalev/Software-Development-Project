using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Services.Interfaces
{
    public interface ILoanService
    {
        Task<IEnumerable<Loan>> GetAllLoansAsync();
        Task<Loan?> GetLoanByIdAsync(int id);
        Task<Loan?> GetLoanWithDetailsAsync(int id);

        Task<Loan?> CreateLoanAsync(Loan loan);
        Task<bool> ReturnLoanAsync(int loanId, AssetCondition returnCondition);

        Task<IEnumerable<Loan>> GetActiveLoansAsync();
        Task<IEnumerable<Loan>> GetOverdueLoansAsync();
        Task<IEnumerable<Loan>> GetLoansByPersonAsync(int personId);
        Task<IEnumerable<Loan>> GetLoansByAssetAsync(int assetId);

        Task UpdateOverdueLoansAsync();
    }
}