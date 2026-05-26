using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Services.Helpers;

namespace SchoolLab.WinFormsUI.Helpers
{
    public static class DatabaseSeeder
    {
        public static void Seed(SchoolLabDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { Name = "Computers" },
                    new Category { Name = "Peripherals" },
                    new Category { Name = "Networking" }
                );
                context.SaveChanges();
            }

            if (!context.Locations.Any())
            {
                context.Locations.AddRange(
                    new Location { Name = "Lab A" },
                    new Location { Name = "Lab B" },
                    new Location { Name = "Storage" }
                );
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User { Username = "AdminTestUser", PasswordHash = PasswordHasher.HashPassword("admin123"), DisplayName = "Admin User", Role = UserRole.Administrator, TimeOfRegistration = DateTime.Now },
                    new User { Username = "AssistantTestUser", PasswordHash = PasswordHasher.HashPassword("labassist123"), DisplayName = "Lab Assistant", Role = UserRole.LabAssistant, TimeOfRegistration = DateTime.Now },
                    new User { Username = "ViewerTestUser", PasswordHash = PasswordHasher.HashPassword("viewer123"), DisplayName = "Viewer User", Role = UserRole.Viewer, TimeOfRegistration = DateTime.Now }
                );
                context.SaveChanges();
            }

            if (!context.Assets.Any())
            {
                var computers = context.Categories.First(c => c.Name == "Computers");
                var peripherals = context.Categories.First(c => c.Name == "Peripherals");
                var labA = context.Locations.First(l => l.Name == "Lab A");
                var labB = context.Locations.First(l => l.Name == "Lab B");

                context.Assets.AddRange(
                    new Asset { Name = "Dell OptiPlex 7080", SerialNumber = "DL-7080-0001", Category = computers, CategoryId = computers.Id, StoredLocation = labA, LocationId = labA.Id, DateOfPurchase = DateTime.UtcNow.AddYears(-2), Condition = AssetCondition.Excellent, Status = AssetStatus.Available },
                    new Asset { Name = "HP ProBook 450", SerialNumber = "HP-450-0002", Category = computers, CategoryId = computers.Id, StoredLocation = labB, LocationId = labB.Id, DateOfPurchase = DateTime.UtcNow.AddYears(-1).AddMonths(-3), Condition = AssetCondition.MinorDamage, Status = AssetStatus.Available },
                    new Asset { Name = "Dell 24\" Monitor", SerialNumber = "MON-2401-0003", Category = peripherals, CategoryId = peripherals.Id, StoredLocation = labA, LocationId = labA.Id, DateOfPurchase = DateTime.UtcNow.AddYears(-3), Condition = AssetCondition.InNeedOfRepair, Status = AssetStatus.InRepair }
                );
                context.SaveChanges();
            }

        }
    }
}
