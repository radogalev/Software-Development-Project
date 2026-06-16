using SchoolLab.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolLab.Core.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        [Required]
        public User Leaser { get; set; }
        public int AssetId { get; set; }
        public int BorrowerId { get; set; }
        public AssetCondition? ReturnCondition { get; set; }
        public int LeaserId { get; set; }
        public LoanStatus Status { get; set; }

        [Required]
        public Asset BorrowedAsset { get; set; }

        [Required]
        public User Borrower { get; set; }
    }

    
}