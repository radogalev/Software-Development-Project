using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolLab.Core.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
        public ICollection<Asset> Assets { get; set; }
    }
}