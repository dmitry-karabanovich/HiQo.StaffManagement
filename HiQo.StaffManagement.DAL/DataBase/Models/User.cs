using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HiQo.StaffManagement.DAL.DataBase.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public int PositionLevelId { get; set; }
        public PositionLevel PositionLevel { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
