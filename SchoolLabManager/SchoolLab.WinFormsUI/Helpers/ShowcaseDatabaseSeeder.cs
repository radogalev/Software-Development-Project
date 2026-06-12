using SchoolLab.Core.Enums;
using SchoolLab.Core.Models;
using SchoolLab.Data.Context;
using SchoolLab.Services.Helpers;

namespace SchoolLab.WinFormsUI.Helpers
{
    public static class ShowcaseDatabaseSeeder
    {
        public static void Seed(SchoolLabDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any() || context.Assets.Any() || context.Loans.Any() || context.DamageReports.Any())
            {
                return;
            }

            var categories = new[]
            {
                new Category { Name = "Computers", Description = "Desktop computers and workstations" },
                new Category { Name = "Laptops", Description = "Portable classroom laptops" },
                new Category { Name = "Tablets", Description = "Tablet devices for demonstrations" },
                new Category { Name = "Peripherals", Description = "Monitors, keyboards, mice, and webcams" },
                new Category { Name = "Networking", Description = "Routers, switches, and access points" },
                new Category { Name = "Audio Visual", Description = "Projectors, speakers, microphones, and cameras" },
                new Category { Name = "Lab Tools", Description = "Electronics and repair lab equipment" }
            };

            var locations = new[]
            {
                new Location { Name = "Lab A", Description = "Main teaching computer lab" },
                new Location { Name = "Lab B", Description = "Secondary teaching lab" },
                new Location { Name = "Robotics Lab", Description = "Makerspace and robotics room" },
                new Location { Name = "Media Room", Description = "Audio visual storage and editing suite" },
                new Location { Name = "Storage", Description = "Secure equipment storage" },
                new Location { Name = "Repair Desk", Description = "Items waiting for repair or inspection" }
            };

            var users = new[]
            {
                new User { Username = "AdminTestUser", PasswordHash = PasswordHasher.HashPassword("admin123"), DisplayName = "Admin User", Role = UserRole.Administrator, TimeOfRegistration = DateTime.Now.AddMonths(-9) },
                new User { Username = "MorganAdmin", PasswordHash = PasswordHasher.HashPassword("admin123"), DisplayName = "Morgan Ellis", Role = UserRole.Administrator, TimeOfRegistration = DateTime.Now.AddMonths(-7) },
                new User { Username = "AssistantTestUser", PasswordHash = PasswordHasher.HashPassword("labassist123"), DisplayName = "Lab Assistant", Role = UserRole.LabAssistant, TimeOfRegistration = DateTime.Now.AddMonths(-8) },
                new User { Username = "SamAssistant", PasswordHash = PasswordHasher.HashPassword("labassist123"), DisplayName = "Sam Rivera", Role = UserRole.LabAssistant, TimeOfRegistration = DateTime.Now.AddMonths(-6) },
                new User { Username = "ViewerTestUser", PasswordHash = PasswordHasher.HashPassword("viewer123"), DisplayName = "Viewer User", Role = UserRole.Viewer, TimeOfRegistration = DateTime.Now.AddMonths(-5) },
                new User { Username = "AvaStudent", PasswordHash = PasswordHasher.HashPassword("viewer123"), DisplayName = "Ava Stone", Role = UserRole.Viewer, TimeOfRegistration = DateTime.Now.AddMonths(-4) },
                new User { Username = "NoahStudent", PasswordHash = PasswordHasher.HashPassword("viewer123"), DisplayName = "Noah Brooks", Role = UserRole.Viewer, TimeOfRegistration = DateTime.Now.AddMonths(-3) },
                new User { Username = "MiaStudent", PasswordHash = PasswordHasher.HashPassword("viewer123"), DisplayName = "Mia Chen", Role = UserRole.Viewer, TimeOfRegistration = DateTime.Now.AddMonths(-2) },
                new User { Username = "LeoStudent", PasswordHash = PasswordHasher.HashPassword("viewer123"), DisplayName = "Leo Novak", Role = UserRole.Viewer, TimeOfRegistration = DateTime.Now.AddDays(-35) },
                new User { Username = "SofiaStudent", PasswordHash = PasswordHasher.HashPassword("viewer123"), DisplayName = "Sofia Marin", Role = UserRole.Viewer, TimeOfRegistration = DateTime.Now.AddDays(-18) }
            };

            context.Categories.AddRange(categories);
            context.Locations.AddRange(locations);
            context.Users.AddRange(users);
            context.SaveChanges();

            var computers = categories.Single(c => c.Name == "Computers");
            var laptops = categories.Single(c => c.Name == "Laptops");
            var tablets = categories.Single(c => c.Name == "Tablets");
            var peripherals = categories.Single(c => c.Name == "Peripherals");
            var networking = categories.Single(c => c.Name == "Networking");
            var audioVisual = categories.Single(c => c.Name == "Audio Visual");
            var labTools = categories.Single(c => c.Name == "Lab Tools");

            var labA = locations.Single(l => l.Name == "Lab A");
            var labB = locations.Single(l => l.Name == "Lab B");
            var roboticsLab = locations.Single(l => l.Name == "Robotics Lab");
            var mediaRoom = locations.Single(l => l.Name == "Media Room");
            var storage = locations.Single(l => l.Name == "Storage");
            var repairDesk = locations.Single(l => l.Name == "Repair Desk");

            var assets = new[]
            {
                new Asset { Name = "Dell OptiPlex 7080", SerialNumber = "DL-7080-0001", Category = computers, StoredLocation = labA, DateOfPurchase = DateTime.UtcNow.AddYears(-2), Condition = AssetCondition.Excellent, Status = AssetStatus.Available, Description = "Instructor workstation with dual-display support." },
                new Asset { Name = "HP EliteDesk 800", SerialNumber = "HP-800-0002", Category = computers, StoredLocation = labA, DateOfPurchase = DateTime.UtcNow.AddYears(-3), Condition = AssetCondition.MinorDamage, Status = AssetStatus.Available, Description = "Front-row classroom desktop, scratched side panel." },
                new Asset { Name = "Lenovo ThinkCentre M720", SerialNumber = "LN-M720-0003", Category = computers, StoredLocation = labB, DateOfPurchase = DateTime.UtcNow.AddYears(-4), Condition = AssetCondition.Excellent, Status = AssetStatus.Available, Description = "General lab desktop." },
                new Asset { Name = "HP ProBook 450", SerialNumber = "HP-450-0004", Category = laptops, StoredLocation = labB, DateOfPurchase = DateTime.UtcNow.AddYears(-1).AddMonths(-4), Condition = AssetCondition.MinorDamage, Status = AssetStatus.Borrowed, Description = "Loaner laptop with small keyboard scuff." },
                new Asset { Name = "Dell Latitude 5420", SerialNumber = "DL-5420-0005", Category = laptops, StoredLocation = storage, DateOfPurchase = DateTime.UtcNow.AddYears(-1), Condition = AssetCondition.Excellent, Status = AssetStatus.Borrowed, Description = "Portable laptop for project presentations." },
                new Asset { Name = "Acer Chromebook 514", SerialNumber = "AC-514-0006", Category = laptops, StoredLocation = storage, DateOfPurchase = DateTime.UtcNow.AddMonths(-16), Condition = AssetCondition.InNeedOfRepair, Status = AssetStatus.InRepair, Description = "Charging port is unreliable." },
                new Asset { Name = "iPad 10th Gen", SerialNumber = "IPAD-001", Category = tablets, StoredLocation = mediaRoom, DateOfPurchase = DateTime.UtcNow.AddMonths(-9), Condition = AssetCondition.Excellent, Status = AssetStatus.Borrowed, Description = "Tablet for media recording assignments." },
                new Asset { Name = "Samsung Galaxy Tab S7", SerialNumber = "SGT-S7-002", Category = tablets, StoredLocation = storage, DateOfPurchase = DateTime.UtcNow.AddYears(-2), Condition = AssetCondition.MajorDamage, Status = AssetStatus.InRepair, Description = "Cracked screen, usable for demos only after repair." },
                new Asset { Name = "Dell 24 Inch Monitor", SerialNumber = "MON-2401-0008", Category = peripherals, StoredLocation = labA, DateOfPurchase = DateTime.UtcNow.AddYears(-3), Condition = AssetCondition.Excellent, Status = AssetStatus.Available, Description = "External monitor." },
                new Asset { Name = "Logitech C920 Webcam", SerialNumber = "WEB-C920-0009", Category = peripherals, StoredLocation = mediaRoom, DateOfPurchase = DateTime.UtcNow.AddYears(-2), Condition = AssetCondition.Excellent, Status = AssetStatus.Borrowed, Description = "Webcam for hybrid lessons." },
                new Asset { Name = "Mechanical Keyboard Kit", SerialNumber = "KEY-KIT-0010", Category = peripherals, StoredLocation = roboticsLab, DateOfPurchase = DateTime.UtcNow.AddMonths(-13), Condition = AssetCondition.MinorDamage, Status = AssetStatus.Available, Description = "Keyboard kit missing one spare keycap." },
                new Asset { Name = "Cisco Catalyst 2960 Switch", SerialNumber = "CS-2960-0011", Category = networking, StoredLocation = labB, DateOfPurchase = DateTime.UtcNow.AddYears(-5), Condition = AssetCondition.Excellent, Status = AssetStatus.Available, Description = "Managed switch for networking exercises." },
                new Asset { Name = "TP-Link Archer Router", SerialNumber = "TPL-ARCH-0012", Category = networking, StoredLocation = labB, DateOfPurchase = DateTime.UtcNow.AddYears(-2), Condition = AssetCondition.MajorDamage, Status = AssetStatus.Disposed, Description = "Disposed after power failure." },
                new Asset { Name = "Epson Projector EB-X49", SerialNumber = "EPS-X49-0013", Category = audioVisual, StoredLocation = mediaRoom, DateOfPurchase = DateTime.UtcNow.AddYears(-2), Condition = AssetCondition.MinorDamage, Status = AssetStatus.Available, Description = "Projector with dim lamp warning." },
                new Asset { Name = "Blue Yeti Microphone", SerialNumber = "MIC-BY-0014", Category = audioVisual, StoredLocation = mediaRoom, DateOfPurchase = DateTime.UtcNow.AddMonths(-20), Condition = AssetCondition.Excellent, Status = AssetStatus.Borrowed, Description = "USB microphone for podcast projects." },
                new Asset { Name = "Canon EOS M50 Camera", SerialNumber = "CAN-M50-0015", Category = audioVisual, StoredLocation = mediaRoom, DateOfPurchase = DateTime.UtcNow.AddYears(-3), Condition = AssetCondition.InNeedOfRepair, Status = AssetStatus.InRepair, Description = "Lens mount needs inspection." },
                new Asset { Name = "Arduino Starter Kit", SerialNumber = "ARD-KIT-0016", Category = labTools, StoredLocation = roboticsLab, DateOfPurchase = DateTime.UtcNow.AddYears(-1), Condition = AssetCondition.Excellent, Status = AssetStatus.Available, Description = "Electronics starter kit." },
                new Asset { Name = "Soldering Station", SerialNumber = "SOL-ST-0017", Category = labTools, StoredLocation = repairDesk, DateOfPurchase = DateTime.UtcNow.AddYears(-4), Condition = AssetCondition.InNeedOfRepair, Status = AssetStatus.InRepair, Description = "Temperature control drifts during use." },
                new Asset { Name = "Digital Multimeter", SerialNumber = "DMM-0018", Category = labTools, StoredLocation = roboticsLab, DateOfPurchase = DateTime.UtcNow.AddYears(-2), Condition = AssetCondition.Excellent, Status = AssetStatus.Available, Description = "General diagnostics tool." },
                new Asset { Name = "Old VGA Projector", SerialNumber = "VGA-OLD-0019", Category = audioVisual, StoredLocation = storage, DateOfPurchase = DateTime.UtcNow.AddYears(-9), Condition = AssetCondition.BeyoundRepair, Status = AssetStatus.Disposed, Description = "Retired legacy projector." }
            };

            context.Assets.AddRange(assets);
            context.SaveChanges();

            var admin = users.Single(u => u.Username == "AdminTestUser");
            var assistant = users.Single(u => u.Username == "AssistantTestUser");
            var samAssistant = users.Single(u => u.Username == "SamAssistant");
            var viewer = users.Single(u => u.Username == "ViewerTestUser");
            var ava = users.Single(u => u.Username == "AvaStudent");
            var noah = users.Single(u => u.Username == "NoahStudent");
            var mia = users.Single(u => u.Username == "MiaStudent");
            var leo = users.Single(u => u.Username == "LeoStudent");
            var sofia = users.Single(u => u.Username == "SofiaStudent");

            var hpProBook = assets.Single(a => a.Name == "HP ProBook 450");
            var latitude = assets.Single(a => a.Name == "Dell Latitude 5420");
            var ipad = assets.Single(a => a.Name == "iPad 10th Gen");
            var webcam = assets.Single(a => a.Name == "Logitech C920 Webcam");
            var microphone = assets.Single(a => a.Name == "Blue Yeti Microphone");
            var monitor = assets.Single(a => a.Name == "Dell 24 Inch Monitor");
            var arduino = assets.Single(a => a.Name == "Arduino Starter Kit");
            var camera = assets.Single(a => a.Name == "Canon EOS M50 Camera");
            var chromebook = assets.Single(a => a.Name == "Acer Chromebook 514");
            var tablet = assets.Single(a => a.Name == "Samsung Galaxy Tab S7");
            var solderingStation = assets.Single(a => a.Name == "Soldering Station");

            var loans = new[]
            {
                new Loan { BorrowedAsset = hpProBook, AssetId = hpProBook.Id, Borrower = ava, BorrowerId = ava.Id, Leaser = assistant, LeaserId = assistant.Id, BorrowDate = DateTime.Now.AddDays(-5), DueDate = DateTime.Now.AddDays(9), Status = LoanStatus.Active },
                new Loan { BorrowedAsset = latitude, AssetId = latitude.Id, Borrower = noah, BorrowerId = noah.Id, Leaser = admin, LeaserId = admin.Id, BorrowDate = DateTime.Now.AddDays(-3), DueDate = DateTime.Now.AddDays(4), Status = LoanStatus.Active },
                new Loan { BorrowedAsset = ipad, AssetId = ipad.Id, Borrower = mia, BorrowerId = mia.Id, Leaser = assistant, LeaserId = assistant.Id, BorrowDate = DateTime.Now.AddDays(-11), DueDate = DateTime.Now.AddDays(-2), Status = LoanStatus.Overdue },
                new Loan { BorrowedAsset = webcam, AssetId = webcam.Id, Borrower = leo, BorrowerId = leo.Id, Leaser = samAssistant, LeaserId = samAssistant.Id, BorrowDate = DateTime.Now.AddDays(-2), DueDate = DateTime.Now.AddDays(12), Status = LoanStatus.Active },
                new Loan { BorrowedAsset = microphone, AssetId = microphone.Id, Borrower = sofia, BorrowerId = sofia.Id, Leaser = assistant, LeaserId = assistant.Id, BorrowDate = DateTime.Now.AddDays(-9), DueDate = DateTime.Now.AddDays(1), Status = LoanStatus.Active },
                new Loan { BorrowedAsset = monitor, AssetId = monitor.Id, Borrower = viewer, BorrowerId = viewer.Id, Leaser = admin, LeaserId = admin.Id, BorrowDate = DateTime.Now.AddDays(-30), DueDate = DateTime.Now.AddDays(-20), ReturnDate = DateTime.Now.AddDays(-21), ReturnCondition = AssetCondition.Excellent, Status = LoanStatus.Returned },
                new Loan { BorrowedAsset = arduino, AssetId = arduino.Id, Borrower = ava, BorrowerId = ava.Id, Leaser = samAssistant, LeaserId = samAssistant.Id, BorrowDate = DateTime.Now.AddDays(-25), DueDate = DateTime.Now.AddDays(-10), ReturnDate = DateTime.Now.AddDays(-7), ReturnCondition = AssetCondition.MinorDamage, Status = LoanStatus.ReturnedLate },
                new Loan { BorrowedAsset = camera, AssetId = camera.Id, Borrower = noah, BorrowerId = noah.Id, Leaser = assistant, LeaserId = assistant.Id, BorrowDate = DateTime.Now.AddDays(-55), DueDate = DateTime.Now.AddDays(-40), ReturnDate = DateTime.Now.AddDays(-39), ReturnCondition = AssetCondition.InNeedOfRepair, Status = LoanStatus.ReturnedLate }
            };

            context.Loans.AddRange(loans);
            context.SaveChanges();

            var reports = new[]
            {
                new DamageReport { BorrowedAsset = chromebook, AssetId = chromebook.Id, ReportedBy = assistant, ReportedById = assistant.Id, RepairedBy = samAssistant, RepairedById = samAssistant.Id, DateReported = DateTime.Now.AddDays(-16), Description = "Charging port disconnects unless cable is held at an angle." },
                new DamageReport { BorrowedAsset = tablet, AssetId = tablet.Id, ReportedBy = admin, ReportedById = admin.Id, RepairedBy = null, RepairedById = null, DateReported = DateTime.Now.AddDays(-24), Description = "Screen glass cracked across the top-right corner." },
                new DamageReport { BorrowedAsset = camera, AssetId = camera.Id, Loan = loans.Single(l => l.BorrowedAsset == camera), LoanId = loans.Single(l => l.BorrowedAsset == camera).Id, ReportedBy = noah, ReportedById = noah.Id, RepairedBy = assistant, RepairedById = assistant.Id, DateReported = DateTime.Now.AddDays(-38), Description = "Lens mount sticks after camera was returned late." },
                new DamageReport { BorrowedAsset = arduino, AssetId = arduino.Id, Loan = loans.Single(l => l.BorrowedAsset == arduino), LoanId = loans.Single(l => l.BorrowedAsset == arduino).Id, ReportedBy = ava, ReportedById = ava.Id, RepairedBy = null, RepairedById = null, DateReported = DateTime.Now.AddDays(-8), Description = "Several jumper wires missing; breadboard adhesive loose." },
                new DamageReport { BorrowedAsset = solderingStation, AssetId = solderingStation.Id, ReportedBy = samAssistant, ReportedById = samAssistant.Id, RepairedBy = null, RepairedById = null, DateReported = DateTime.Now.AddDays(-6), Description = "Temperature control fluctuates during soldering practice." },
                new DamageReport { BorrowedAsset = microphone, AssetId = microphone.Id, Loan = loans.Single(l => l.BorrowedAsset == microphone), LoanId = loans.Single(l => l.BorrowedAsset == microphone).Id, ReportedBy = sofia, ReportedById = sofia.Id, RepairedBy = assistant, RepairedById = assistant.Id, DateReported = DateTime.Now.AddDays(-2), Description = "USB cable crackles unless seated firmly." }
            };

            context.DamageReports.AddRange(reports);
            context.SaveChanges();
        }
    }
}
