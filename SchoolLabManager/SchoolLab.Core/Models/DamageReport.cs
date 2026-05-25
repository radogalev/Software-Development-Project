using System;

namespace SchoolLab.Core.Models
{
    public class DamageReport
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateReported { get; set; }
        public Asset BorrowedAsset { get; set; }
        public Loan? Loan { get; set; } //If not part of loan
        public User? RepairedBy { get; set; } //If not yet repaired
        public User ReportedBy { get; set; }
        public int AssetId { get; set; }
        public int? LoanId { get; set; }
        public int ReportedById { get; set; }
        public int? RepairedById { get; set; }
    }
}
