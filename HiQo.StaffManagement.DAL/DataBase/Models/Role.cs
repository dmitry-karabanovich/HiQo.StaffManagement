using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HiQo.StaffManagement.DAL.DataBase.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public Role()
        {
            Users = new List<User>();
        }
    }
}
