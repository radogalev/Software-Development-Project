using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Models;

namespace SchoolLab.Data.Context
{
    public class SchoolLabDbContext : DbContext
    {
        // Parameterless constructor remains for normal usage where OnConfiguring is used.
        public SchoolLabDbContext() { }

        // Constructor that accepts DbContextOptions so tests can supply an in-memory provider.
        public SchoolLabDbContext(DbContextOptions<SchoolLabDbContext> options) : base(options) { }
        // DbSets - these represent database tables
        // Each DbSet<T> becomes a table named after the property (Users, Assets, etc.)
        public DbSet<User> Users { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<DamageReport> DamageReports { get; set; }

        // OnConfiguring - tells EF Core HOW to connect to the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If options were provided externally (e.g. by tests using InMemory), don't override them.
            if (optionsBuilder.IsConfigured)
            {
                return;
            }

            // UseSqlServer = we're using SQL Server (LocalDB in this case)
            // Connection string breakdown:
            // - Server=(localdb)\\mssqllocaldb = use LocalDB instance
            // - Database=SchoolLabDB = database name
            // - Trusted_Connection=true = use Windows authentication (no username/password needed)
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=SchoolLabDB;Trusted_Connection=true;"
            );
        }

        // OnModelCreating - configure relationships, constraints, and rules
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ==================== ASSET CONFIGURATIONS ====================

            // Asset -> Category relationship (many Assets to one Category)
            modelBuilder.Entity<Asset>()
                .HasOne(a => a.Category)           // Asset has one Category
                .WithMany(c => c.Assets)           // Category has many Assets
                .HasForeignKey(a => a.CategoryId)  // Foreign key is CategoryId
                .OnDelete(DeleteBehavior.Restrict); // Prevent deleting Category if it has Assets

            // Asset -> Location relationship (many Assets to one Location)
            modelBuilder.Entity<Asset>()
                .HasOne(a => a.StoredLocation)
                .WithMany(l => l.Assets)
                .HasForeignKey(a => a.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Make Asset.Name required (not null)
            modelBuilder.Entity<Asset>()
                .Property(a => a.Name)
                .IsRequired();

            // ==================== LOAN CONFIGURATIONS ====================

            // Loan -> Asset relationship (many Loans to one Asset)
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.BorrowedAsset)
                .WithMany(a => a.Loans)
                .HasForeignKey(l => l.AssetId)
                .OnDelete(DeleteBehavior.Restrict); // Can't delete Asset if it has Loans

            // Loan -> Person relationship (many Loans to one Person/Borrower)
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Borrower)
                .WithMany(p => p.Loans)
                .HasForeignKey(l => l.BorrowerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Loan -> User relationship (who created the loan - the "Leaser")
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Leaser)
                .WithMany()  // User doesn't have a Loans collection, so empty
                .HasForeignKey(l => l.LeaserId)
                .OnDelete(DeleteBehavior.Restrict);

            // ==================== DAMAGE REPORT CONFIGURATIONS ====================

            // DamageReport -> Asset relationship
            modelBuilder.Entity<DamageReport>()
                .HasOne(dr => dr.BorrowedAsset)
                .WithMany(a => a.DamageReports)
                .HasForeignKey(dr => dr.AssetId)
                .OnDelete(DeleteBehavior.Restrict);

            // DamageReport -> Loan relationship (optional - damage might not be from a loan)
            modelBuilder.Entity<DamageReport>()
                .HasOne(dr => dr.Loan)
                .WithMany()  // Loan doesn't track its damage reports
                .HasForeignKey(dr => dr.LoanId)
                .OnDelete(DeleteBehavior.SetNull); // If Loan deleted, set LoanId to null

            // DamageReport -> User (ReportedBy) relationship
            modelBuilder.Entity<DamageReport>()
                .HasOne(dr => dr.ReportedBy)
                .WithMany()
                .HasForeignKey(dr => dr.ReportedById)
                .OnDelete(DeleteBehavior.Restrict);

            // DamageReport -> User (RepairedBy) relationship (optional)
            modelBuilder.Entity<DamageReport>()
                .HasOne(dr => dr.RepairedBy)
                .WithMany()
                .HasForeignKey(dr => dr.RepairedById)
                .OnDelete(DeleteBehavior.SetNull);

            // ==================== USER CONFIGURATIONS ====================

            // Make Username unique (no duplicate usernames)
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            // Make Username required
            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired();

            // Make PasswordHash required
            modelBuilder.Entity<User>()
                .Property(u => u.PasswordHash)
                .IsRequired();



            // ==================== CATEGORY & LOCATION CONFIGURATIONS ====================

            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .IsRequired();

            modelBuilder.Entity<Location>()
                .Property(l => l.Name)
                .IsRequired();
        }
    }
}