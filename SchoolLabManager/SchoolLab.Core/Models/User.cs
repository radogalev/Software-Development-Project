using SchoolLab.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolLab.Core.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public UserRole Role { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(100)]
        public string DisplayName { get; set; }
        public DateTime TimeOfRegistration { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}