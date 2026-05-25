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
    public class AuthServiceTests
    {
        private (SchoolLabDbContext ctx, AuthService svc) Setup(string dbName)
        {
            var ctx = DbFactory.Create(dbName);
            var svc = new AuthService(new UserRepository(ctx));
            return (ctx, svc);
        }

        [Test]
        public async Task RegisterUserAsync_CreatesUser_WithHashedPassword()
        {
            var (ctx, svc) = Setup("authsvc_register");

            var user = new User { Username = "alice", DisplayName = "Alice", Role = UserRole.Administrator };
            var ok = await svc.RegisterUserAsync(user, "password123");

            Assert.IsTrue(ok);
            Assert.AreEqual(1, ctx.Users.Count());

            var saved = ctx.Users.First();
            Assert.AreEqual("alice", saved.Username);
            Assert.AreNotEqual("password123", saved.PasswordHash);
        }

        [Test]
        public async Task RegisterUserAsync_ReturnsFalse_WhenUsernameAlreadyExists()
        {
            var (ctx, svc) = Setup("authsvc_duplicate");

            var user1 = new User { Username = "bob", DisplayName = "Bob", Role = UserRole.Viewer };
            await svc.RegisterUserAsync(user1, "pass1");

            var user2 = new User { Username = "bob", DisplayName = "Bob2", Role = UserRole.Viewer };
            var ok = await svc.RegisterUserAsync(user2, "pass2");

            Assert.IsFalse(ok);
            Assert.AreEqual(1, ctx.Users.Count());
        }

        [Test]
        public async Task LoginAsync_ReturnsUser_WithCorrectCredentials()
        {
            var (ctx, svc) = Setup("authsvc_login");

            var user = new User { Username = "carol", DisplayName = "Carol", Role = UserRole.Administrator };
            await svc.RegisterUserAsync(user, "mypassword");

            var result = await svc.LoginAsync("carol", "mypassword");
            Assert.IsNotNull(result);
            Assert.AreEqual("carol", result.Username);
        }

        [Test]
        public async Task LoginAsync_ReturnsNull_WithWrongPassword()
        {
            var (ctx, svc) = Setup("authsvc_wrongpass");

            var user = new User { Username = "dave", DisplayName = "Dave", Role = UserRole.Viewer };
            await svc.RegisterUserAsync(user, "correct");

            var result = await svc.LoginAsync("dave", "wrong");
            Assert.IsNull(result);
        }

        [Test]
        public async Task LoginAsync_ReturnsNull_WhenUserDoesNotExist()
        {
            var (ctx, svc) = Setup("authsvc_nouser");

            var result = await svc.LoginAsync("ghost", "pass");
            Assert.IsNull(result);
        }

        [Test]
        public async Task ChangePasswordAsync_UpdatesHash_WhenOldPasswordIsCorrect()
        {
            var (ctx, svc) = Setup("authsvc_changepw");

            var user = new User { Username = "eve", DisplayName = "Eve", Role = UserRole.Administrator };
            await svc.RegisterUserAsync(user, "oldpass");

            var saved = ctx.Users.First();
            var ok = await svc.ChangePasswordAsync(saved.Id, "oldpass", "newpass");
            Assert.IsTrue(ok);

            var loginNew = await svc.LoginAsync("eve", "newpass");
            Assert.IsNotNull(loginNew);

            var loginOld = await svc.LoginAsync("eve", "oldpass");
            Assert.IsNull(loginOld);
        }

        [Test]
        public async Task ChangePasswordAsync_ReturnsFalse_WhenOldPasswordWrong()
        {
            var (ctx, svc) = Setup("authsvc_changepw_wrong");

            var user = new User { Username = "frank", DisplayName = "Frank", Role = UserRole.Viewer };
            await svc.RegisterUserAsync(user, "realpass");

            var saved = ctx.Users.First();
            var ok = await svc.ChangePasswordAsync(saved.Id, "wrongpass", "newpass");
            Assert.IsFalse(ok);
        }
    }
}
