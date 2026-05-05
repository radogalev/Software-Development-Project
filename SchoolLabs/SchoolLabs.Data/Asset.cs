using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Import the folder with all enums
using SchoolLabs.Data.Enums;

namespace SchoolLabs.Data
{
    internal class Asset
    {
        public int AssetId { get; set; }
        public string Name { get; set; }
        public string InventoryNumber {  get; set; }
        public string SerialNumber { get; set; }
        //Used as if making a class object
        public AssetStatus status { get; set; }
        public AssetCondition condition { get; set; }
        public AssetCategory category { get; set; }
        public Location Locations { get; set; }
        public ICollection <Loan> Loans { get; set; }
        public void ExampleUsage()
        {
            //       Name       .Value
            status = AssetStatus.Borrowed;
        }
    }
}
