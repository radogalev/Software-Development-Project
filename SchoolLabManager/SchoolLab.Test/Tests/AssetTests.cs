using NUnit.Framework;
using SchoolLab.Core.Models;

namespace SchoolLab.Test
{
    public class AssetTests
    {
        [Test]
        public void Asset_Defaults()
        {
            var a = new Asset { Id = 1, Name = "A" };
            Assert.AreEqual(1, a.Id);
            Assert.AreEqual("A", a.Name);
            Assert.IsNull(a.Category);
            Assert.IsNull(a.StoredLocation);
        }
    }
}
