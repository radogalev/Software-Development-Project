using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLabs.Data
{
    internal class Location
    {
        public int LocationId {  get; set; }
        public string LocationName { get; set; }
        public ICollection<Asset> Assets { get; set; }

    }
}
