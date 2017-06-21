using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Entity
{
    public class Role
    {
        public Role()
        {
            UserRoles = new List<UserRole>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
}
