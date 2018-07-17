using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Models;

namespace HiQo.StaffManagement.DAL.Configuration
{
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.Property(g => g.UserId).IsRequired();
            this.Property(g => g.DateOfBirth).IsRequired();
            this.Property(g => g.FirstName).IsRequired().HasMaxLength(25);
            this.Property(g => g.LastName).IsRequired().HasMaxLength(25);
            this.Property(g => g.DateOfBirth).IsRequired();
            this.HasRequired(g => g.Role).WithMany(r => r.Users).HasForeignKey(g => g.RoleId);
            this.HasRequired(g => g.Position).WithMany(r => r.Users).HasForeignKey(g => g.PositionId);
        }
    }
}
