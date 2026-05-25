using System.Collections.Generic;

namespace SchoolLab.Core.Models
{
    public class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string? Description { get; set; }
        public ICollection<Asset> Assets { get; set; }
    }
}
