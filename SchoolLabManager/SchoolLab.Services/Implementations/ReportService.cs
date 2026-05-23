using SchoolLab.Core.Models;
using SchoolLab.Data.Repositories.Interfaces;
using SchoolLab.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace SchoolLab.Services.Implementations
{
    public class ReportService : IReportService
    {
        private readonly ILoanRepository _loanRepo;
        private readonly IAssetRepository _assetRepo;
        private readonly IDamageReportRepository _reportsRepo;

        public ReportService(ILoanRepository loanRepo, IAssetRepository assetRepo, IDamageReportRepository reportsRepo)
        {
            _loanRepo = loanRepo;
            _assetRepo = assetRepo;
            _reportsRepo = reportsRepo;
        }

        public async Task<IEnumerable<Loan>> GetOverdueLoansReportAsync()
        {
            return await _loanRepo.GetOverdueLoansAsync();
        }
        public async Task<IEnumerable<Loan>> GetLoansByPersonReportAsync(int personId)
        {
            return await _loanRepo.GetLoansByPersonAsync(personId);
        }
        public async Task<IEnumerable<Asset>> GetAssetsByLocationReportAsync(int locationId)
        {
            return await _assetRepo.GetAssetsByLocationAsync(locationId);
        }
        public async Task<IEnumerable<DamageReport>> GetDamageReportsByAssetAsync(int assetId)
        {
            return await _reportsRepo.GetDamageReportsByAssetAsync(assetId);
        }

        public async Task<IEnumerable<Asset>> GetMostBorrowedAssetsAsync(int topCount = 10)
        {
            var topAssetIds = (await _loanRepo.GetAllAsync())
                .GroupBy(l => l.AssetId)
                .OrderByDescending(g => g.Count())
                .Take(topCount)
                .Select(g => g.Key)  
                .ToList();

            List<Asset> assets = new List<Asset>();
            foreach (int assetId in topAssetIds)
            {
                var asset = await _assetRepo.GetByIdAsync(assetId);
                if (asset != null)
                {
                    assets.Add(asset);
                }
            }

            return assets;


        }

        public async Task<Dictionary<User, int>> GetPeopleWithMostOverdueLoansAsync(int topCount = 10)
        {
            var overdueLoans = await _loanRepo.GetOverdueLoansAsync();

            var grouped = overdueLoans
                .GroupBy(l => l.BorrowerId)
                .OrderByDescending(g => g.Count())
                .Take(topCount);

            Dictionary<User, int> dict = new Dictionary<User, int>();

            foreach (var group in grouped)
            {
                int personId = group.Key;           
                int count = group.Count();          

                
                var person = group.First().Borrower;

                dict.Add(person, count);
            }

            return dict; 
        }
    }
}
