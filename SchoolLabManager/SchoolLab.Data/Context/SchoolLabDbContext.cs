using Microsoft.EntityFrameworkCore;
using SchoolLab.Core.Models;

namespace SchoolLab.Data.Context
{
    public class SchoolLabDbContext : DbContext
    {
        
        public SchoolLabDbContext() { }

        // Constructor that accepts DbContextOptions so tests can supply an in-memory provider.
        public SchoolLabDbContext(DbContextOptions<SchoolLabDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<DamageReport> DamageReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If options were provided externally (e.g. by tests using InMemory), don't override them.
            if (optionsBuilder.IsConfigured)
            {
                return;
            }

            // UseSqlServer = we're using SQL Server (LocalDB)
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
            // ASSET CONFIGURATIONS 

            // Asset -> Category relationship
            modelBuilder.Entity<Asset>()
                .HasOne(a => a.Category)           
                .WithMany(c => c.Assets)           
                .HasForeignKey(a => a.CategoryId)  
                .OnDelete(DeleteBehavior.Restrict); 

            // Asset -> Location relationship
            modelBuilder.Entity<Asset>()
                .HasOne(a => a.StoredLocation)
                .WithMany(l => l.Assets)
                .HasForeignKey(a => a.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Asset>()
                .Property(a => a.Name)
                .IsRequired();

            // LOAN CONFIGURATIONS 

            // Loan -> Asset relationship
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.BorrowedAsset)
                .WithMany(a => a.Loans)
                .HasForeignKey(l => l.AssetId)
                .OnDelete(DeleteBehavior.Restrict);

            // Loan -> Person relationship (Borrower)
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Borrower)
                .WithMany(p => p.Loans)
                .HasForeignKey(l => l.BorrowerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Loan -> User relationship (Leaser)
            modelBuilder.Entity<Loan>()
                .HasOne(l => l.Leaser)
                .WithMany()
                .HasForeignKey(l => l.LeaserId)
                .OnDelete(DeleteBehavior.Restrict);

            // DAMAGE REPORT CONFIGURATIONS 

            // DamageReport -> Asset relationship
            modelBuilder.Entity<DamageReport>()
                .HasOne(dr => dr.BorrowedAsset)
                .WithMany(a => a.DamageReports)
                .HasForeignKey(dr => dr.AssetId)
                .OnDelete(DeleteBehavior.Restrict);

            // DamageReport -> Loan relationship (optional)
            modelBuilder.Entity<DamageReport>()
                .HasOne(dr => dr.Loan)
                .WithMany() 
                .HasForeignKey(dr => dr.LoanId)
                .OnDelete(DeleteBehavior.SetNull);

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

            //USER CONFIGURATIONS

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.PasswordHash)
                .IsRequired();



            // CATEGORY & LOCATION CONFIGURATIONS 
            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .IsRequired();

            modelBuilder.Entity<Location>()
                .Property(l => l.Name)
                .IsRequired();
        }
    }
}