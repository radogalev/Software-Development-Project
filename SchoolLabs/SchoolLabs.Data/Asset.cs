using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLabs.Data
{
    internal class Asset
    {
        public int AssetId { get; set; }
        public string Name { get; set; }
        public string InventoryNumber {  get; set; }
        public string SerialNumber { get; set; }
        public enum Status
        {

        }
        public enum Condition
        {
            Available,
            Borrowed,
            In_Repair,
            Scrapped
        }
        public enum Category
        {
            Laptop,
            Computer,
            Arduino,
            Furniture,
            Sports_Equipment
        }
        public Location Locations { get; set; }
        public ICollection <Loan> Loans { get; set; }
    }
}
