using System.Collections.Generic;

namespace SchoolLab.Core.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Asset> Assets { get; set; }
    }
}
