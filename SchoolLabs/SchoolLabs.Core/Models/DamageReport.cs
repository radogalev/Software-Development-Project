using SchoolLabs.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLabs.Data
{
    public class DamageReport
    {
        public int ReportId { get; set; }
        public int LoanId { get; set; } 
        public int AssetId { get; set; } 
        public bool HasBeenRepaired { get; set; }
        public string Description { get; set; }
        public DamageSeverity Severity { get; set; }

    }


}
