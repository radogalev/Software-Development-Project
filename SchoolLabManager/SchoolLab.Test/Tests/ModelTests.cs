using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;

namespace SchoolLab.Test.Tests
{

    [TestFixture]
    public class ModelTests
    {
        [Test]
        public void Category_Properties_AreSetCorrectly()
        {
            var c = new Category { Id = 2, Name = "Electronics", Description = "Electronic equipment" };
            Assert.AreEqual(2, c.Id);
            Assert.AreEqual("Electronics", c.Name);
            Assert.AreEqual("Electronic equipment", c.Description);
            Assert.IsNull(c.Assets);
        }

        [Test]
        public void Location_Properties_AreSetCorrectly()
        {
            var l = new Location { Id = 3, Name = "Cabinet", Description = "Storage cabinet" };
            Assert.AreEqual(3, l.Id);
            Assert.AreEqual("Cabinet", l.Name);
            Assert.AreEqual("Storage cabinet", l.Description);
            Assert.IsNull(l.Assets);
        }

        [Test]
        public void User_Properties_AreSetCorrectly()
        {
            var u = new User { Id = 4, Username = "bob", DisplayName = "Bob Smith", PasswordHash = "hash", Role = UserRole.Administrator };
            Assert.AreEqual(4, u.Id);
            Assert.AreEqual("bob", u.Username);
            Assert.AreEqual("Bob Smith", u.DisplayName);
            Assert.AreEqual(UserRole.Administrator, u.Role);
            Assert.IsNull(u.Loans);
        }

        [Test]
        public void Asset_Defaults_AreCorrect()
        {
            var a = new Asset { Id = 1, Name = "Laptop" };
            Assert.AreEqual(1, a.Id);
            Assert.AreEqual("Laptop", a.Name);
            Assert.IsNull(a.Category);
            Assert.IsNull(a.StoredLocation);
            Assert.IsNull(a.Description);
        }

        [Test]
        public void Loan_Properties_AreSetCorrectly()
        {
            var due = DateTime.Today.AddDays(7);
            var l = new Loan { Id = 1, AssetId = 10, BorrowerId = 1, LeaserId = 2, DueDate = due, Status = LoanStatus.Active };
            Assert.AreEqual(LoanStatus.Active, l.Status);
            Assert.AreEqual(due, l.DueDate);
            Assert.AreEqual(10, l.AssetId);
        }

        [Test]
        public void DamageReport_Properties_AreSetCorrectly()
        {
            var date = DateTime.Today;
            var r = new DamageReport { Id = 1, AssetId = 5, Description = "Cracked screen", DateReported = date };
            Assert.AreEqual(1, r.Id);
            Assert.AreEqual(5, r.AssetId);
            Assert.AreEqual("Cracked screen", r.Description);
            Assert.AreEqual(date, r.DateReported);
        }
    }
}
