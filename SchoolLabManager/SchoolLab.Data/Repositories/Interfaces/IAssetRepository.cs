using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Data.Repositories.Interfaces
{
    // Asset-specific repository with custom methods
    public interface IAssetRepository : IRepository<Asset>
    {
        Task<IEnumerable<Asset>> GetAssetsByStatusAsync(AssetStatus status);

        Task<IEnumerable<Asset>> GetAssetsByLocationAsync(int locationId);

        Task<IEnumerable<Asset>> GetAssetsByCategoryAsync(int categoryId);

        Task<Asset?> GetAssetWithDetailsAsync(int id);

        Task<IEnumerable<Asset>> GetAllWithDetailsAsync();
    }
}