namespace HiQo.StaffManagement.Core.Models
{
    public class UpsertUser
    {
        public int UpsertUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }

        public int DepartmentId { get; set; }
        public int CategoryId { get; set; }
        public int PositionId { get; set; }
        public int PositionLevelId { get; set; }
        public int RoleId { get; set; }

    }
}
