using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Services.Implementations;

namespace SchoolLab.Test.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        private (SchoolLabDbContext ctx, UserService svc) Setup(string dbName)
        {
            var options = new DbContextOptionsBuilder<SchoolLabDbContext>()
                .UseInMemoryDatabase(dbName)
                .Options;
            var ctx = new SchoolLabDbContext(options);
            var svc = new UserService(new UserRepository(ctx));
            return (ctx, svc);
        }

        private User MakeUser(int id, string username, UserRole role = UserRole.Viewer) => new User
        {
            Id = id,
            Username = username,
            DisplayName = username,
            PasswordHash = "hash",
            Role = role
        };

        [Test]
        public async Task GetAllUsersAsync_ReturnsAllUsers()
        {
            var (ctx, svc) = Setup("usersvc_getall");
            ctx.Users.AddRange(
                MakeUser(1, "alice"),
                MakeUser(2, "bob"),
                MakeUser(3, "carol")
            );
            await ctx.SaveChangesAsync();

            var result = (await svc.GetAllUsersAsync()).ToList();
            Assert.AreEqual(3, result.Count);
        }

        [Test]
        public async Task GetAllUsersAsync_ReturnsEmpty_WhenNoUsers()
        {
            var (ctx, svc) = Setup("usersvc_getall_empty");
            var result = (await svc.GetAllUsersAsync()).ToList();
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public async Task GetByIdAsync_ReturnsCorrectUser()
        {
            var (ctx, svc) = Setup("usersvc_getbyid");
            ctx.Users.AddRange(MakeUser(1, "alice"), MakeUser(2, "bob"));
            await ctx.SaveChangesAsync();

            var result = await svc.GetByIdAsync(2);
            Assert.IsNotNull(result);
            Assert.AreEqual("bob", result.Username);
        }

        [Test]
        public async Task GetByIdAsync_ReturnsNull_WhenNotFound()
        {
            var (ctx, svc) = Setup("usersvc_getbyid_null");
            var result = await svc.GetByIdAsync(999);
            Assert.IsNull(result);
        }

        [Test]
        public async Task DeleteUserAsync_RemovesUser_WhenExists()
        {
            var (ctx, svc) = Setup("usersvc_delete");
            ctx.Users.Add(MakeUser(1, "alice"));
            await ctx.SaveChangesAsync();

            var ok = await svc.DeleteUserAsync(1);
            Assert.IsTrue(ok);
            Assert.AreEqual(0, ctx.Users.Count());
        }

        [Test]
        public async Task DeleteUserAsync_ReturnsFalse_WhenNotFound()
        {
            var (ctx, svc) = Setup("usersvc_delete_notfound");
            var ok = await svc.DeleteUserAsync(999);
            Assert.IsFalse(ok);
        }

        [Test]
        public async Task DeleteUserAsync_OnlyRemovesTargetUser()
        {
            var (ctx, svc) = Setup("usersvc_delete_specific");
            ctx.Users.AddRange(MakeUser(1, "alice"), MakeUser(2, "bob"));
            await ctx.SaveChangesAsync();

            await svc.DeleteUserAsync(1);

            Assert.AreEqual(1, ctx.Users.Count());
            Assert.AreEqual("bob", ctx.Users.First().Username);
        }

        [Test]
        public async Task GetAllUsersAsync_PreservesRoles()
        {
            var (ctx, svc) = Setup("usersvc_roles");
            ctx.Users.AddRange(
                MakeUser(1, "admin", UserRole.Administrator),
                MakeUser(2, "viewer", UserRole.Viewer)
            );
            await ctx.SaveChangesAsync();

            var result = (await svc.GetAllUsersAsync()).ToList();
            Assert.IsTrue(result.Any(u => u.Role == UserRole.Administrator));
            Assert.IsTrue(result.Any(u => u.Role == UserRole.Viewer));
        }
    }
}