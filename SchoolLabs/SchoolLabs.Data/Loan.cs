using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLabs.Data
{
    internal class Loan
    {
        public int LoanId {  get; set; }
        public int AssetId {  get; set; }
        public int PersonId {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public enum Status
        {

        }
        public Asset Asset { get; set; }
        public User IssuedByUser { get; set; }
        public ICollection<Damage_Reports> Damage_Reports { get; set; }

    }
}
