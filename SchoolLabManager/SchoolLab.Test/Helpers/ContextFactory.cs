using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLab.Test.Helpers
{
    internal static class DbFactory
    {
        public static SchoolLabDbContext Create(string name)
        {
            var options = new DbContextOptionsBuilder<SchoolLabDbContext>()
                .UseInMemoryDatabase(name)
                .Options;
            return new SchoolLabDbContext(options);
        }

        public static async Task<(Category cat, Location loc)> SeedCategoryAndLocationAsync(SchoolLabDbContext ctx)
        {
            var cat = new Category { Id = 1, Name = "Electronics" };
            var loc = new Location { Id = 1, Name = "Room 101" };
            ctx.Categories.Add(cat);
            ctx.Locations.Add(loc);
            await ctx.SaveChangesAsync();
            return (cat, loc);
        }

        public static async Task<User> SeedUserAsync(SchoolLabDbContext ctx, int id = 1, UserRole role = UserRole.Administrator)
        {
            var user = new User
            {
                Id = id,
                Username = $"user{id}",
                DisplayName = $"User {id}",
                PasswordHash = "placeholder",
                Role = role
            };
            ctx.Users.Add(user);
            await ctx.SaveChangesAsync();
            return user;
        }

        public static async Task<Asset> SeedAssetAsync(SchoolLabDbContext ctx, int id = 10,
            AssetStatus status = AssetStatus.Available, AssetCondition condition = AssetCondition.Excellent)
        {
            var asset = new Asset
            {
                Id = id,
                Name = $"Asset{id}",
                CategoryId = 1,
                LocationId = 1,
                Status = status,
                Condition = condition,
                SerialNumber = $"SN{id}"
            };
            ctx.Assets.Add(asset);
            await ctx.SaveChangesAsync();
            return asset;
        }
    }
}
