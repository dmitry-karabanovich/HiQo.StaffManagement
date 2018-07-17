using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiQo.StaffManagement.DAL.DataBase.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public Position()
        {
            Users = new List<User>();
        }
    }
}
