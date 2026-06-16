using SchoolLab.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolLab.Core.Models
{
    public class Asset
    {

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateOfPurchase { get; set; }

        [Required]
        public Category Category { get; set; }

        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string? SerialNumber { get; set; }
        public AssetCondition Condition { get; set; }
        public AssetStatus Status { get; set; }
        public int LocationId { get; set; }

        [Required]
        public Location StoredLocation { get; set; }
        public ICollection<Loan> Loans { get; set; }
        public ICollection<DamageReport> DamageReports { get; set; }
    }
}