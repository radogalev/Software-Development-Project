using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Data.Repositories.Interfaces;
using SchoolLab.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolLab.Services.Implementations
{
    public class AssetService : IAssetService
    {
        private readonly IAssetRepository _repo;
        public AssetService(IAssetRepository repository)
        {
            _repo = repository;
        }
        public async Task<IEnumerable<Asset>> GetAllAssetsAsync()
        {
            if (_repo is AssetRepository ar)
            {
                return await ar.GetAllWithDetailsAsync();
            }
            return await _repo.GetAllAsync();
        }

        public async Task<Asset?> GetAssetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task<Asset?> GetAssetWithDetailsAsync(int id)
        {
            // Return the asset with related details when available
            return await _repo.GetAssetWithDetailsAsync(id);
        }

        public async Task<Asset> CreateAssetAsync(Asset asset)
        {
            await _repo.AddAsync(asset);
            await _repo.SaveChangesAsync();
            // Return the created asset with related data populated when possible
            if (_repo is AssetRepository ar)
            {
                var created = await ar.GetAssetWithDetailsAsync(asset.Id);
                if (created != null)
                    return created;
            }
            return asset;
        }
        public async Task<Asset> UpdateAssetAsync(Asset asset)
        {
            _repo.Update(asset);
            await _repo.SaveChangesAsync();
            if (_repo is AssetRepository ar)
            {
                var updated = await ar.GetAssetWithDetailsAsync(asset.Id);
                return updated ?? asset;
            }
            return asset;
        }
        public async Task<bool> DeleteAssetAsync(int id)
        {
            Asset? asset = await _repo.GetAssetWithDetailsAsync(id);

            if (asset == null)
            {
                return false;
            }

            if (asset.Loans.Any(x => x.Status is LoanStatus.Active or LoanStatus.Overdue))
            {
                return false;
            }
            else
            {
                _repo.Delete(asset);
                await _repo.SaveChangesAsync();
                return true;
            }
        }


        public async Task<IEnumerable<Asset>> GetAssetsByStatusAsync(AssetStatus status)
        {
            if (_repo is AssetRepository ar)
            {
                return await ar.GetAssetsByStatusAsync(status);
            }
            return await _repo.GetAssetsByStatusAsync(status);
        }
        public async Task<IEnumerable<Asset>> GetAssetsByLocationAsync(int locationId)
        {
            if (_repo is AssetRepository ar)
            {
                return await ar.GetAssetsByLocationAsync(locationId);
            }
            return await _repo.GetAssetsByLocationAsync(locationId);
        }
        public async Task<IEnumerable<Asset>> GetAssetsByCategoryAsync(int categoryId)

        {
            if (_repo is AssetRepository ar)
            {
                return await ar.GetAssetsByCategoryAsync(categoryId);
            }
            return await _repo.GetAssetsByCategoryAsync(categoryId);
        }

        public async Task<bool> ChangeAssetLocationAsync(int assetId, int newLocationId)
        {
            Asset? asset = await _repo.GetByIdAsync(assetId);
            if (asset == null)
            {
                return false;
            }
            asset.LocationId = newLocationId;
            _repo.Update(asset);
            await _repo.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ChangeAssetStatusAsync(int assetId, AssetStatus newStatus)
        {
            Asset? asset = await _repo.GetByIdAsync(assetId);
            if (asset == null)
            {
                return false;
            }
            asset.Status = newStatus;
            _repo.Update(asset);
            await _repo.SaveChangesAsync();
            return true;
        }

    }
}
