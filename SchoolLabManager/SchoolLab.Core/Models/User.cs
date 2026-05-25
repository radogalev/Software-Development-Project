using SchoolLab.Core.Enums;
using System;
using System.Collections.Generic;

namespace SchoolLab.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public UserRole Role { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string DisplayName { get; set; }
        public DateTime TimeOfRegistration { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
