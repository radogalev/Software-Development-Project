using NUnit.Framework;
using SchoolLab.Core.Models;
using SchoolLab.Core.Enums;

namespace SchoolLab.Test
{
    public class ModelTests
    {
        [Test]
        public void Category_Defaults()
        {
            var c = new Category { Id = 2, Name = "Electronics" };
            Assert.AreEqual(2, c.Id);
            Assert.AreEqual("Electronics", c.Name);
            Assert.IsNull(c.Description);
            Assert.IsNull(c.Assets);
        }

        [Test]
        public void Location_Defaults()
        {
            var l = new Location { Id = 3, Name = "Cabinet" };
            Assert.AreEqual(3, l.Id);
            Assert.AreEqual("Cabinet", l.Name);
            Assert.IsNull(l.Description);
            Assert.IsNull(l.Assets);
        }

        [Test]
        public void User_Defaults()
        {
            var u = new User { Id = 4, Username = "bob", DisplayName = "Bob", PasswordHash = "p", Role = UserRole.Administrator };
            Assert.AreEqual(4, u.Id);
            Assert.AreEqual("bob", u.Username);
            Assert.AreEqual("Bob", u.DisplayName);
            Assert.AreEqual(UserRole.Administrator, u.Role);
            Assert.IsNull(u.Loans);
        }
    }
}
