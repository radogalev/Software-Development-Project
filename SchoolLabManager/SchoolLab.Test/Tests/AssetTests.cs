using NUnit.Framework;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Services.Implementations;
using SchoolLab.Test.Helpers;

namespace SchoolLab.Test.Tests
{

    [TestFixture]
    public class AssetServiceTests
    {
        [Test]
        public async Task CreateAssetAsync_AddsAndReturnsAsset()
        {
            using var ctx = DbFactory.Create("assetsvc_create");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var svc = new AssetService(new AssetRepository(ctx));

            var asset = new Asset { Name = "Monitor", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available, Condition = AssetCondition.Excellent };
            var result = await svc.CreateAssetAsync(asset);

            Assert.IsNotNull(result);
            Assert.AreEqual("Monitor", result.Name);
            Assert.AreEqual(1, ctx.Assets.Count());
        }

        [Test]
        public async Task GetAllAssetsAsync_ReturnsAllAssets()
        {
            using var ctx = DbFactory.Create("assetsvc_getall");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var svc = new AssetService(new AssetRepository(ctx));

            await svc.CreateAssetAsync(new Asset { Name = "A1", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available, Condition = AssetCondition.Excellent });
            await svc.CreateAssetAsync(new Asset { Name = "A2", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available, Condition = AssetCondition.MinorDamage });

            var all = (await svc.GetAllAssetsAsync()).ToList();
            Assert.AreEqual(2, all.Count);
        }

        [Test]
        public async Task UpdateAssetAsync_PersistsChanges()
        {
            using var ctx = DbFactory.Create("assetsvc_update");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var repo = new AssetRepository(ctx);
            var svc = new AssetService(repo);

            var asset = new Asset { Id = 50, Name = "Old", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available, Condition = AssetCondition.Excellent };
            ctx.Assets.Add(asset);
            await ctx.SaveChangesAsync();

            asset.Name = "Updated";
            asset.Condition = AssetCondition.MinorDamage;
            await svc.UpdateAssetAsync(asset);

            var fetched = await repo.GetByIdAsync(50);
            Assert.AreEqual("Updated", fetched.Name);
            Assert.AreEqual(AssetCondition.MinorDamage, fetched.Condition);
        }

        [Test]
        public async Task DeleteAssetAsync_RemovesAsset_WhenNoActiveLoans()
        {
            using var ctx = DbFactory.Create("assetsvc_delete");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var repo = new AssetRepository(ctx);
            var svc = new AssetService(repo);

            var asset = new Asset { Id = 60, Name = "ToDelete", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available, Condition = AssetCondition.Excellent };
            ctx.Assets.Add(asset);
            await ctx.SaveChangesAsync();

            var deleted = await svc.DeleteAssetAsync(60);
            Assert.IsTrue(deleted);
            Assert.AreEqual(0, ctx.Assets.Count());
        }

        [Test]
        public async Task DeleteAssetAsync_ReturnsFalse_WhenAssetNotFound()
        {
            using var ctx = DbFactory.Create("assetsvc_delete_notfound");
            var svc = new AssetService(new AssetRepository(ctx));

            var result = await svc.DeleteAssetAsync(999);
            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetAssetsByStatusAsync_FiltersCorrectly()
        {
            using var ctx = DbFactory.Create("assetsvc_bystatus");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var svc = new AssetService(new AssetRepository(ctx));

            await svc.CreateAssetAsync(new Asset { Name = "Available1", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available, Condition = AssetCondition.Excellent });
            await svc.CreateAssetAsync(new Asset { Name = "OnLoan1", CategoryId = 1, LocationId = 1, Status = AssetStatus.Borrowed, Condition = AssetCondition.Excellent });

            var available = (await svc.GetAssetsByStatusAsync(AssetStatus.Available)).ToList();
            Assert.AreEqual(1, available.Count);
            Assert.AreEqual("Available1", available[0].Name);
        }
    }
}
