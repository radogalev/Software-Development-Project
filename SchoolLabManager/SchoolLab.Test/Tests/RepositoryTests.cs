using NUnit.Framework;
using SchoolLab.Data.Context;
using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Models;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Core.Enums;
using System;

namespace SchoolLab.Test
{
    public class RepositoryTests
    {
        private SchoolLabDbContext CreateInMemoryContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<SchoolLabDbContext>()
                        .UseInMemoryDatabase(dbName)
                        .Options;
            return new SchoolLabDbContext(options);
        }

        [Test]
        public async Task AssetRepository_CRUD_and_queries()
        {
            var ctx = CreateInMemoryContext("assets_db");
            var repo = new AssetRepository(ctx);

            var cat = new Category { Id = 1, Name = "Cat" };
            var loc = new Location { Id = 1, Name = "Loc" };
            ctx.Categories.Add(cat);
            ctx.Locations.Add(loc);
            await ctx.SaveChangesAsync();

            var asset = new Asset { Id = 10, Name = "Laptop", CategoryId = cat.Id, LocationId = loc.Id, Status = AssetStatus.Available };
            await repo.AddAsync(asset);
            await repo.SaveChangesAsync();

            var fetched = await repo.GetByIdAsync(10);
            Assert.IsNotNull(fetched);
            Assert.AreEqual("Laptop", fetched.Name);

            var byStatus = (await repo.GetAssetsByStatusAsync(AssetStatus.Available)).ToList();
            Assert.AreEqual(1, byStatus.Count);

            var allDetails = (await repo.GetAllWithDetailsAsync()).ToList();
            Assert.AreEqual(1, allDetails.Count);
            Assert.IsNotNull(allDetails[0].Category);
            Assert.IsNotNull(allDetails[0].StoredLocation);

            // Update
            fetched.Name = "Laptop2";
            repo.Update(fetched);
            await repo.SaveChangesAsync();
            var updated = await repo.GetByIdAsync(10);
            Assert.AreEqual("Laptop2", updated.Name);

            // Delete
            repo.Delete(updated);
            await repo.SaveChangesAsync();
            var deleted = await repo.GetByIdAsync(10);
            Assert.IsNull(deleted);
        }

        [Test]
        public async Task LoanRepository_GetActiveAndOverdue()
        {
            var ctx = CreateInMemoryContext("loans_db");
            var repo = new LoanRepository(ctx);
            var user = new User { Id = 1, Username = "u1", DisplayName = "U1", PasswordHash = "p", Role = UserRole.Viewer };
            var asset = new Asset { Id = 20, Name = "Proj" };
            ctx.Users.Add(user);
            ctx.Assets.Add(asset);
            await ctx.SaveChangesAsync();

            var loanActive = new Loan { Id = 100, AssetId = asset.Id, BorrowerId = user.Id, BorrowDate = DateTime.Now.AddDays(-1), DueDate = DateTime.Now.AddDays(1), LeaserId = user.Id, Status = LoanStatus.Active };
            var loanOverdue = new Loan { Id = 101, AssetId = asset.Id, BorrowerId = user.Id, BorrowDate = DateTime.Now.AddDays(-10), DueDate = DateTime.Now.AddDays(-1), LeaserId = user.Id, Status = LoanStatus.Active };
            ctx.Loans.Add(loanActive);
            ctx.Loans.Add(loanOverdue);
            await ctx.SaveChangesAsync();

            var active = (await repo.GetActiveLoansAsync()).ToList();
            Assert.AreEqual(2, active.Count);

            var overdue = (await repo.GetOverdueLoansAsync()).ToList();
            Assert.AreEqual(1, overdue.Count);
            Assert.AreEqual(101, overdue[0].Id);
            Assert.AreEqual(1, 1);
        }
    }
}
