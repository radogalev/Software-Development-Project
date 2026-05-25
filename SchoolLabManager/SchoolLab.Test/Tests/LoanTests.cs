using NUnit.Framework;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Services.Implementations;
using SchoolLab.Test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLab.Test.Tests
{
    [TestFixture]
    public class LoanServiceTests
    {
        private async Task<(SchoolLabDbContext ctx, LoanService svc, User user, Asset asset)> SetupAsync(string dbName)
        {
            var ctx = DbFactory.Create(dbName);
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var user = await DbFactory.SeedUserAsync(ctx);
            var asset = await DbFactory.SeedAssetAsync(ctx, status: AssetStatus.Available);
            var svc = new LoanService(new AssetRepository(ctx), new LoanRepository(ctx));
            return (ctx, svc, user, asset);
        }

        [Test]
        public async Task CreateLoanAsync_CreatesLoan_AndSetsAssetOnLoan()
        {
            var (ctx, svc, user, asset) = await SetupAsync("loansvc_create");

            var loan = new Loan
            {
                AssetId = asset.Id,
                BorrowerId = user.Id,
                LeaserId = user.Id,
                DueDate = DateTime.Now.AddDays(7),
                BorrowDate = DateTime.Now,
                Status = LoanStatus.Active
            };

            var result = await svc.CreateLoanAsync(loan);

            Assert.IsNotNull(result);
            Assert.AreEqual(LoanStatus.Active, result.Status);

            var updatedAsset = await ctx.Assets.FindAsync(asset.Id);
            Assert.AreEqual(AssetStatus.Borrowed, updatedAsset.Status);
        }

        [Test]
        public async Task CreateLoanAsync_ReturnsNull_WhenAssetUnavailable()
        {
            var (ctx, svc, user, asset) = await SetupAsync("loansvc_unavailable");

            asset.Status = AssetStatus.Borrowed;
            ctx.Assets.Update(asset);
            await ctx.SaveChangesAsync();

            var loan = new Loan
            {
                AssetId = asset.Id,
                BorrowerId = user.Id,
                LeaserId = user.Id,
                DueDate = DateTime.Now.AddDays(7),
                BorrowDate = DateTime.Now,
                Status = LoanStatus.Active
            };

            var result = await svc.CreateLoanAsync(loan);
            Assert.IsNull(result);
        }

        [Test]
        public async Task ReturnLoanAsync_SetsReturnedStatus_AndAssetAvailable()
        {
            var (ctx, svc, user, asset) = await SetupAsync("loansvc_return");

            var loan = new Loan
            {
                Id = 1,
                AssetId = asset.Id,
                BorrowerId = user.Id,
                LeaserId = user.Id,
                DueDate = DateTime.Now.AddDays(7),
                BorrowDate = DateTime.Now,
                Status = LoanStatus.Active
            };
            ctx.Loans.Add(loan);
            asset.Status = AssetStatus.Borrowed;
            ctx.Assets.Update(asset);
            await ctx.SaveChangesAsync();

            var ok = await svc.ReturnLoanAsync(loan.Id, AssetCondition.Excellent);

            Assert.IsTrue(ok);

            var updatedLoan = await ctx.Loans.FindAsync(loan.Id);
            Assert.AreEqual(LoanStatus.Returned, updatedLoan.Status);

            var updatedAsset = await ctx.Assets.FindAsync(asset.Id);
            Assert.AreEqual(AssetStatus.Available, updatedAsset.Status);
            Assert.AreEqual(AssetCondition.Excellent, updatedAsset.Condition);
        }

        [Test]
        public async Task ReturnLoanAsync_SetsReturnedLate_WhenPastDueDate()
        {
            var (ctx, svc, user, asset) = await SetupAsync("loansvc_returnlate");

            var loan = new Loan
            {
                Id = 2,
                AssetId = asset.Id,
                BorrowerId = user.Id,
                LeaserId = user.Id,
                DueDate = DateTime.Now.AddDays(-3),
                BorrowDate = DateTime.Now.AddDays(-10),
                Status = LoanStatus.Active
            };
            ctx.Loans.Add(loan);
            asset.Status = AssetStatus.Borrowed;
            ctx.Assets.Update(asset);
            await ctx.SaveChangesAsync();

            var ok = await svc.ReturnLoanAsync(loan.Id, AssetCondition.MinorDamage);

            Assert.IsTrue(ok);
            var updatedLoan = await ctx.Loans.FindAsync(loan.Id);
            Assert.AreEqual(LoanStatus.ReturnedLate, updatedLoan.Status);
        }

        [Test]
        public async Task ReturnLoanAsync_ReturnsFalse_WhenLoanNotFound()
        {
            var (ctx, svc, user, asset) = await SetupAsync("loansvc_return_notfound");
            var ok = await svc.ReturnLoanAsync(999, AssetCondition.Excellent);
            Assert.IsFalse(ok);
        }

        [Test]
        public async Task ReturnLoanAsync_ReturnsFalse_WhenAlreadyReturned()
        {
            var (ctx, svc, user, asset) = await SetupAsync("loansvc_already_returned");

            var loan = new Loan
            {
                Id = 3,
                AssetId = asset.Id,
                BorrowerId = user.Id,
                LeaserId = user.Id,
                DueDate = DateTime.Now.AddDays(7),
                BorrowDate = DateTime.Now.AddDays(-5),
                Status = LoanStatus.Returned
            };
            ctx.Loans.Add(loan);
            await ctx.SaveChangesAsync();

            var ok = await svc.ReturnLoanAsync(loan.Id, AssetCondition.Excellent);
            Assert.IsFalse(ok);
        }

        [Test]
        public async Task GetAllLoansAsync_ReturnsAllLoans()
        {
            var (ctx, svc, user, asset) = await SetupAsync("loansvc_getall");

            ctx.Loans.AddRange(
                new Loan { Id = 10, AssetId = asset.Id, BorrowerId = user.Id, LeaserId = user.Id, DueDate = DateTime.Now.AddDays(5), BorrowDate = DateTime.Now, Status = LoanStatus.Active },
                new Loan { Id = 11, AssetId = asset.Id, BorrowerId = user.Id, LeaserId = user.Id, DueDate = DateTime.Now.AddDays(-1), BorrowDate = DateTime.Now.AddDays(-5), Status = LoanStatus.Returned }
            );
            await ctx.SaveChangesAsync();

            var all = (await svc.GetAllLoansAsync()).ToList();
            Assert.AreEqual(2, all.Count);
        }
    }
}
