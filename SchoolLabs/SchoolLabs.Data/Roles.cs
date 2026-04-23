namespace SchoolLabs.Data
{
    public class Roles
    {
       public int RoledId {  get; set; }
        public enum RoleName { 
            Administrator,
            Lab_Assistant,
            Viewer
        }
        public ICollection<User> Users { get; set; }
    }
}
