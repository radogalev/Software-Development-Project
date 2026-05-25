using NUnit.Framework;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Services.Implementations;
using SchoolLab.Test.Helpers;

namespace SchoolLab.Test.Tests
{
    [TestFixture]
    public class ReportServiceTests
    {
        private async Task<(SchoolLabDbContext ctx, ReportService svc, User user, Asset asset)> SetupAsync(string dbName)
        {
            var ctx = DbFactory.Create(dbName);
            await DbFactory.SeedCategoryAndLocationAsync(ctx);
            var user = await DbFactory.SeedUserAsync(ctx);
            var asset = await DbFactory.SeedAssetAsync(ctx);
            var svc = new ReportService(new LoanRepository(ctx), new AssetRepository(ctx), new DamageReportRepository(ctx));
            return (ctx, svc, user, asset);
        }

        [Test]
        public async Task CreateReportAsync_AddsReport()
        {
            var (ctx, svc, user, asset) = await SetupAsync("reportsvc_create");

            var report = new DamageReport
            {
                AssetId = asset.Id,
                ReportedById = user.Id,
                Description = "Broken screen",
                DateReported = DateTime.Today
            };

            var result = await svc.CreateReportAsync(report);

            Assert.IsNotNull(result);
            Assert.AreEqual("Broken screen", result.Description);
            Assert.AreEqual(1, ctx.DamageReports.Count());
        }

        [Test]
        public async Task GetAllReportsAsync_ReturnsAllReports()
        {
            var (ctx, svc, user, asset) = await SetupAsync("reportsvc_getall");

            ctx.DamageReports.AddRange(
                new DamageReport { AssetId = asset.Id, ReportedById = user.Id, Description = "R1", DateReported = DateTime.Today },
                new DamageReport { AssetId = asset.Id, ReportedById = user.Id, Description = "R2", DateReported = DateTime.Today }
            );
            await ctx.SaveChangesAsync();

            var all = (await svc.GetAllReportsAsync()).ToList();
            Assert.AreEqual(2, all.Count);
        }

        [Test]
        public async Task GetReportByIdAsync_ReturnsCorrectReport()
        {
            var (ctx, svc, user, asset) = await SetupAsync("reportsvc_getbyid");

            var report = new DamageReport { Id = 5, AssetId = asset.Id, ReportedById = user.Id, Description = "Scratch", DateReported = DateTime.Today };
            ctx.DamageReports.Add(report);
            await ctx.SaveChangesAsync();

            var result = await svc.GetDamageReportByIdAsync(5);
            Assert.IsNotNull(result);
            Assert.AreEqual("Scratch", result.Description);
        }

        [Test]
        public async Task GetReportByIdAsync_ReturnsNull_WhenNotFound()
        {
            var (ctx, svc, user, asset) = await SetupAsync("reportsvc_null");
            var result = await svc.GetDamageReportByIdAsync(999);
            Assert.IsNull(result);
        }

        [Test]
        public async Task DeleteReportAsync_RemovesReport()
        {
            var (ctx, svc, user, asset) = await SetupAsync("reportsvc_delete");

            var report = new DamageReport { Id = 10, AssetId = asset.Id, ReportedById = user.Id, Description = "ToDelete", DateReported = DateTime.Today };
            ctx.DamageReports.Add(report);
            await ctx.SaveChangesAsync();

            var ok = await svc.DeleteReportAsync(10);
            Assert.IsTrue(ok);
            Assert.AreEqual(0, ctx.DamageReports.Count());
        }

        [Test]
        public async Task DeleteReportAsync_ReturnsFalse_WhenNotFound()
        {
            var (ctx, svc, user, asset) = await SetupAsync("reportsvc_delete_notfound");
            var ok = await svc.DeleteReportAsync(999);
            Assert.IsFalse(ok);
        }

        [Test]
        public async Task GetReportsByAssetAsync_FiltersCorrectly()
        {
            var (ctx, svc, user, asset) = await SetupAsync("reportsvc_byasset");

            await DbFactory.SeedAssetAsync(ctx, id: 11);

            ctx.DamageReports.AddRange(
                new DamageReport { AssetId = asset.Id, ReportedById = user.Id, Description = "R-asset10", DateReported = DateTime.Today },
                new DamageReport { AssetId = 11, ReportedById = user.Id, Description = "R-asset11", DateReported = DateTime.Today }
            );
            await ctx.SaveChangesAsync();

            var results = (await svc.GetDamageReportsByAssetAsync(asset.Id)).ToList();
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("R-asset10", results[0].Description);
        }
    }
}
