using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Services.Interfaces
{
    public interface ILoanService
    {
        // CRUD
        Task<IEnumerable<Loan>> GetAllLoansAsync();
        Task<Loan?> GetLoanByIdAsync(int id);
        Task<Loan?> GetLoanWithDetailsAsync(int id);

        // Business operations
        Task<Loan?> CreateLoanAsync(Loan loan); // Returns created Loan (with details) or null if creation failed
        Task<bool> ReturnLoanAsync(int loanId, AssetCondition returnCondition);

        // Queries
        Task<IEnumerable<Loan>> GetActiveLoansAsync();
        Task<IEnumerable<Loan>> GetOverdueLoansAsync();
        Task<IEnumerable<Loan>> GetLoansByPersonAsync(int personId);
        Task<IEnumerable<Loan>> GetLoansByAssetAsync(int assetId);

        // Utility
        Task UpdateOverdueLoansAsync(); // Marks loans as overdue if past due date
    }
}