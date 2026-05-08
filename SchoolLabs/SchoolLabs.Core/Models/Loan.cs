using SchoolLabs.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLabs.Data
{
    public class Loan
    {
        public int LoanId { get; set; }
        public int AssetId { get; set; }
        public int PersonId { get; set; }
        public int IssuerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LoanStatus Status { get; set; }
        public DateTime? ReturnDate { get; set; }
    }

}
