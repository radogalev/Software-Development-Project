using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLabs.Data.Enums;

namespace SchoolLabs.Data.CollectionClasses
{
    public class UserCollection
    {
        public List<User> Users { get; set; }

        public List<User> GetUsers()
        {
            return Users;
        }

        public List<User> GetRoleUsers(RoleName role)
        {
            return Users.Where(x => x.Role == role).ToList<User>();
        }
        public User GetUsersName(string name)
        {
            return Users.Where(x => x.UserName == name).First();
        }

        }
}
