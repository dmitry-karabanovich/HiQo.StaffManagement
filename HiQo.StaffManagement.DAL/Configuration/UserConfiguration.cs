using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Models;

namespace HiQo.StaffManagement.DAL.Configuration
{
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(g => g.UserId).IsRequired();
            Property(g => g.DateOfBirth).IsRequired();
            Property(g => g.FirstName).IsRequired().HasMaxLength(25);
            Property(g => g.LastName).IsRequired().HasMaxLength(25);
            Property(g => g.DateOfBirth).IsRequired();
            HasRequired(g => g.Role).WithMany(r => r.Users).HasForeignKey(g => g.RoleId);
            HasRequired(g => g.Position).WithMany(r => r.Users).HasForeignKey(g => g.PositionId);
            HasRequired(g => g.PositionLevel).WithMany(r => r.Users).HasForeignKey(g => g.PositionLevelId);
            HasRequired(g => g.Category).WithMany(r => r.Users).HasForeignKey(g => g.CategoryId);
            HasRequired(g => g.Department).WithMany(r => r.Users).HasForeignKey(g => g.DepartmentId);
        }
    }
}
