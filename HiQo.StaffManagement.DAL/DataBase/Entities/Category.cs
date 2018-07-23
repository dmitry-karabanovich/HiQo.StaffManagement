using System.Collections.Generic;

namespace HiQo.StaffManagement.DAL.DataBase.Entities
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
