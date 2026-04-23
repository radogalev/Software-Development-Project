using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLabs.Data
{
    internal class Damage_Report
    {
        public int DamagedId {  get; set; }
        public int LoanId { get; set; }
        public string Description { get; set; }
        public enum Severity
        {
            Low,
            Medium,
            High
        }
    }
    
}
