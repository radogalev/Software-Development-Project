using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Test.Helpers;
using SchoolLab.Data.Repositories.Implementations;

namespace SchoolLab.Test.Tests
{

    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public async Task AssetRepository_Add_And_GetById_ReturnsAsset()
        {
            using var ctx = DbFactory.Create("repo_getbyid");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var repo = new AssetRepository(ctx);

            var asset = new Asset { Id = 10, Name = "Laptop", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available };
            await repo.AddAsync(asset);
            await repo.SaveChangesAsync();

            var result = await repo.GetByIdAsync(10);
            Assert.IsNotNull(result);
            Assert.AreEqual("Laptop", result.Name);
        }

        [Test]
        public async Task AssetRepository_GetByIdAsync_ReturnsNull_WhenNotFound()
        {
            using var ctx = DbFactory.Create("repo_null");
            var repo = new AssetRepository(ctx);

            var result = await repo.GetByIdAsync(999);
            Assert.IsNull(result);
        }

        [Test]
        public async Task AssetRepository_Update_PersistsChanges()
        {
            using var ctx = DbFactory.Create("repo_update");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var repo = new AssetRepository(ctx);

            var asset = new Asset { Id = 11, Name = "OldName", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available };
            await repo.AddAsync(asset);
            await repo.SaveChangesAsync();

            asset.Name = "NewName";
            repo.Update(asset);
            await repo.SaveChangesAsync();

            var updated = await repo.GetByIdAsync(11);
            Assert.AreEqual("NewName", updated.Name);
        }

        [Test]
        public async Task AssetRepository_Delete_RemovesAsset()
        {
            using var ctx = DbFactory.Create("repo_delete");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var repo = new AssetRepository(ctx);

            var asset = new Asset { Id = 12, Name = "ToDelete", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available };
            await repo.AddAsync(asset);
            await repo.SaveChangesAsync();

            repo.Delete(asset);
            await repo.SaveChangesAsync();

            var deleted = await repo.GetByIdAsync(12);
            Assert.IsNull(deleted);
        }

        [Test]
        public async Task AssetRepository_GetByStatus_ReturnsCorrectAssets()
        {
            using var ctx = DbFactory.Create("repo_status");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var repo = new AssetRepository(ctx);

            await repo.AddAsync(new Asset { Id = 20, Name = "A1", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available });
            await repo.AddAsync(new Asset { Id = 21, Name = "A2", CategoryId = 1, LocationId = 1, Status = AssetStatus.Borrowed });
            await repo.SaveChangesAsync();

            var available = (await repo.GetAssetsByStatusAsync(AssetStatus.Available)).ToList();
            Assert.AreEqual(1, available.Count);
            Assert.AreEqual("A1", available[0].Name);
        }

        [Test]
        public async Task AssetRepository_GetAllWithDetails_LoadsNavigationProperties()
        {
            using var ctx = DbFactory.Create("repo_details");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var repo = new AssetRepository(ctx);

            await repo.AddAsync(new Asset { Id = 30, Name = "Proj", CategoryId = 1, LocationId = 1, Status = AssetStatus.Available });
            await repo.SaveChangesAsync();

            var all = (await repo.GetAllWithDetailsAsync()).ToList();
            Assert.AreEqual(1, all.Count);
            Assert.IsNotNull(all[0].Category);
            Assert.IsNotNull(all[0].StoredLocation);
        }

        [Test]
        public async Task LoanRepository_GetActiveLoans_ReturnsOnlyActiveLoans()
        {
            using var ctx = DbFactory.Create("loanrepo_active");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var user = await DbFactory.SeedUserAsync(ctx);
            var asset = await DbFactory.SeedAssetAsync(ctx);
            var repo = new LoanRepository(ctx);

            ctx.Loans.Add(new Loan { Id = 1, AssetId = asset.Id, BorrowerId = user.Id, LeaserId = user.Id, DueDate = DateTime.Now.AddDays(3), BorrowDate = DateTime.Now, Status = LoanStatus.Active });
            ctx.Loans.Add(new Loan { Id = 2, AssetId = asset.Id, BorrowerId = user.Id, LeaserId = user.Id, DueDate = DateTime.Now.AddDays(-1), BorrowDate = DateTime.Now.AddDays(-5), Status = LoanStatus.Returned });
            await ctx.SaveChangesAsync();

            var active = (await repo.GetActiveLoansAsync()).ToList();
            Assert.AreEqual(1, active.Count);
            Assert.AreEqual(LoanStatus.Active, active[0].Status);
        }

        [Test]
        public async Task LoanRepository_GetOverdueLoans_ReturnsOnlyOverdue()
        {
            using var ctx = DbFactory.Create("loanrepo_overdue");
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var user = await DbFactory.SeedUserAsync(ctx);
            var asset = await DbFactory.SeedAssetAsync(ctx);
            var repo = new LoanRepository(ctx);

            ctx.Loans.Add(new Loan { Id = 10, AssetId = asset.Id, BorrowerId = user.Id, LeaserId = user.Id, DueDate = DateTime.Now.AddDays(5), BorrowDate = DateTime.Now, Status = LoanStatus.Active });
            ctx.Loans.Add(new Loan { Id = 11, AssetId = asset.Id, BorrowerId = user.Id, LeaserId = user.Id, DueDate = DateTime.Now.AddDays(-2), BorrowDate = DateTime.Now.AddDays(-10), Status = LoanStatus.Active });
            await ctx.SaveChangesAsync();

            var overdue = (await repo.GetOverdueLoansAsync()).ToList();
            Assert.AreEqual(1, overdue.Count);
            Assert.AreEqual(11, overdue[0].Id);
        }

        [Test]
        public async Task UserRepository_GetByUsername_ReturnsCorrectUser()
        {
            using var ctx = DbFactory.Create("userrepo_byname");
            var repo = new UserRepository(ctx);

            ctx.Users.Add(new User { Id = 1, Username = "alice", DisplayName = "Alice", PasswordHash = "h", Role = UserRole.Administrator });
            ctx.Users.Add(new User { Id = 2, Username = "bob", DisplayName = "Bob", PasswordHash = "h", Role = UserRole.Viewer });
            await ctx.SaveChangesAsync();

            var result = await repo.GetByUsernameAsync("alice");
            Assert.IsNotNull(result);
            Assert.AreEqual("alice", result.Username);
        }

        [Test]
        public async Task UserRepository_GetByUsername_ReturnsNull_WhenNotFound()
        {
            using var ctx = DbFactory.Create("userrepo_notfound");
            var repo = new UserRepository(ctx);

            var result = await repo.GetByUsernameAsync("ghost");
            Assert.IsNull(result);
        }
    }
}
