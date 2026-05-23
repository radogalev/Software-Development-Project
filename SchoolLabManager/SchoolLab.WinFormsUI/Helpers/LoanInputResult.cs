using SchoolLab.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLab.WinFormsUI.Helpers
{
    public class LoanInputResult
    {
        public Asset BorrowedAsset { get; init; } = null;
        public User Borrower { get; init; } = null;
        public DateTime DueDate { get; init; } = DateTime.Today;
    }
}
