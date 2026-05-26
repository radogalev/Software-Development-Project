using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLab.Services.Interfaces
{
    public interface IAssetService
    {
        Task<IEnumerable<Asset>> GetAllAssetsAsync();
        Task<Asset?> GetAssetByIdAsync(int id);
        Task<Asset?> GetAssetWithDetailsAsync(int id);
        Task<Asset> CreateAssetAsync(Asset asset);
        Task<Asset> UpdateAssetAsync(Asset asset);
        Task<bool> DeleteAssetAsync(int id); 

        Task<IEnumerable<Asset>> GetAssetsByStatusAsync(AssetStatus status);
        Task<IEnumerable<Asset>> GetAssetsByLocationAsync(int locationId);
        Task<IEnumerable<Asset>> GetAssetsByCategoryAsync(int categoryId);
        Task<bool> ChangeAssetLocationAsync(int assetId, int newLocationId);
        Task<bool> ChangeAssetStatusAsync(int assetId, AssetStatus newStatus);


    }
}