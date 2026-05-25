using SchoolLab.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Data.Repositories.Interfaces
{
    public interface ILoanRepository : IRepository<Loan>
    {
        // Get active loans (not returned yet)
        Task<IEnumerable<Loan>> GetActiveLoansAsync();

        // Get overdue loans
        Task<IEnumerable<Loan>> GetOverdueLoansAsync();

        // Get loans by person
        Task<IEnumerable<Loan>> GetLoansByPersonAsync(int personId);

        // Get loans by asset
        Task<IEnumerable<Loan>> GetLoansByAssetAsync(int assetId);

        // Get loan with full details (Asset, Person, User)
        Task<Loan?> GetLoanWithDetailsAsync(int id);
        // Get all loans with related details (Asset, Borrower, Leaser)
        Task<IEnumerable<Loan>> GetAllWithDetailsAsync();
    }
}