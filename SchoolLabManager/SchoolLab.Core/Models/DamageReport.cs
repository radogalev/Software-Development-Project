using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolLab.Core.Models
{
    public class DamageReport
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        public DateTime DateReported { get; set; }

        [Required]
        public Asset BorrowedAsset { get; set; }
        public Loan? Loan { get; set; } //If not part of loan
        public User? RepairedBy { get; set; } //If not yet repaired

        [Required]
        public User ReportedBy { get; set; }
        public int AssetId { get; set; }
        public int? LoanId { get; set; }
        public int ReportedById { get; set; }
        public int? RepairedById { get; set; }
    }
}