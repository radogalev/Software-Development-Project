using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Data.Repositories.Interfaces
{
    // Asset-specific repository with custom methods
    public interface IAssetRepository : IRepository<Asset>
    {
        // Get assets by status
        Task<IEnumerable<Asset>> GetAssetsByStatusAsync(AssetStatus status);

        // Get assets by location
        Task<IEnumerable<Asset>> GetAssetsByLocationAsync(int locationId);

        // Get assets by category
        Task<IEnumerable<Asset>> GetAssetsByCategoryAsync(int categoryId);

        // Get asset with all related data (Category, Location, Loans)
        Task<Asset?> GetAssetWithDetailsAsync(int id);
        // Get all assets with related details (Category, Location, Loans, DamageReports)
        Task<IEnumerable<Asset>> GetAllWithDetailsAsync();
    }
}