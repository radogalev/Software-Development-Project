using SchoolLab.Core.Enums;
using System;
using System.Collections.Generic;

namespace SchoolLab.Core.Models
{
    public class Asset
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public Category Category { get; set; }
        public int Id { get; set; }
        public string? SerialNumber { get; set; }
        public AssetCondition Condition { get; set; }
        public AssetStatus Status { get; set; }
        public int LocationId { get; set; }
        public Location StoredLocation { get; set; }
        public ICollection<Loan> Loans { get; set; }
        public ICollection<DamageReport> DamageReports { get; set; }
    }
}
