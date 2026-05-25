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
            if (!context.Users.Any())
            {
                User u1 = new User();
                u1.Username = "AdminTestUser";
                u1.PasswordHash = PasswordHasher.HashPassword("admin123");
                u1.DisplayName = "Admin User";
                u1.Role = UserRole.Administrator;
                u1.TimeOfRegistration = DateTime.Now;

                User u2 = new User();
                u2.Username = "AssistantTestUser";
                u2.PasswordHash = PasswordHasher.HashPassword("labassist123");
                u2.DisplayName = "Lab Assistant";
                u2.Role = UserRole.LabAssistant;
                u2.TimeOfRegistration = DateTime.Now;

                User u3 = new User();
                u3.Username = "ViewerTestUser";
                u3.PasswordHash = PasswordHasher.HashPassword("viewer123");
                u3.DisplayName = "Viewer User";
                u3.Role = UserRole.Viewer;
                u3.TimeOfRegistration = DateTime.Now;

                context.Users.AddRange(u1, u2, u3);
                context.SaveChanges();
            }

            if (!context.Assets.Any())
            {


                var a1 = new Asset
                {
                    Name = "Dell OptiPlex 7080",
                    SerialNumber = "DL-7080-0001",
                    Category = context.Set<Category>().First(c => c.Name == "Computers"),
                    CategoryId = context.Set<Category>().First(c => c.Name == "Computers").Id,
                    StoredLocation = context.Set<Location>().First(l => l.Name == "Lab A"),
                    DateOfPurchase = DateTime.UtcNow.AddYears(-2),
                    Condition = AssetCondition.Excellent,
                    Status = AssetStatus.Available

                };

                var a2 = new Asset
                {
                    Name = "HP ProBook 450",
                    SerialNumber = "HP-450-0002",
                    Category = context.Set<Category>().First(c => c.Name == "Computers"),
                    CategoryId = context.Set<Category>().First(c => c.Name == "Computers").Id,
                    StoredLocation = context.Set<Location>().First(l => l.Name == "Lab B"),
                    DateOfPurchase = DateTime.UtcNow.AddYears(-1).AddMonths(-3),
                    Condition = AssetCondition.MinorDamage,
                    Status = AssetStatus.Borrowed
                };

                var a3 = new Asset
                {
                    Name = "Dell 24\" Monitor",
                    SerialNumber = "MON-2401-0003",
                    Category = context.Set<Category>().First(c => c.Name == "Peripherals"),
                    CategoryId = context.Set<Category>().First(c => c.Name == "Peripherals").Id,
                    StoredLocation = context.Set<Location>().First(l => l.Name == "Lab A"),
                    DateOfPurchase = DateTime.UtcNow.AddYears(-3),
                    Condition = AssetCondition.InNeedOfRepair,
                    Status = AssetStatus.InRepair

                };

                context.Assets.AddRange(a1, a2, a3);

                context.SaveChanges();
            }
        }
    }
}
