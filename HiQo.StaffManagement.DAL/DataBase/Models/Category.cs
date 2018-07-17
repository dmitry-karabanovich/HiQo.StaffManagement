using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiQo.StaffManagement.DAL.DataBase.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public virtual ICollection<Position> CategoriesPositions { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public Category()
        {
            CategoriesPositions = new List<Position>();
            Users = new List<User>();
        }
    }
}
