using Microsoft.EntityFrameworkCore;
using SchoolLabs.Data;
using SchoolLabs.Core.Enums;
using System;

namespace SchoolLabs.Data
{
    public class SchoolLabsDbContext : DbContext
    {
        public SchoolLabsDbContext(DbContextOptions<SchoolLabsDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<DamageReport> DamageReports { get; set; }
        public DbSet<Location> Locations { get; set; }

    }
}