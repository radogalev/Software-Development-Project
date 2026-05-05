using SchoolLabs.Data.Enums;

namespace SchoolLabs.Data
{
    public class Roles
    {
       public int RoledId {  get; set; }
        public RoleName RoleName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
