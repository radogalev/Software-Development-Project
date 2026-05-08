using SchoolLabs.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLabs.Data
{
    public class Asset
    {
        public int AssetId { get; set; }
        public string Name { get; set; }
        public string InventoryNumber {  get; set; }
        public string SerialNumber { get; set; }
        public AssetStatus Status { get; set; }
        public AssetCondition Condition { get; set; }
        public AssetCategory Category { get; set; }
        public int LocationId { get; set; }

    }
}
