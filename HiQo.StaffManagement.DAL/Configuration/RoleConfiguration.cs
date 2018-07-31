using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Entities;

namespace HiQo.StaffManagement.DAL.Configuration
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            Property(g => g.Name).IsRequired().HasMaxLength(20);
            HasMany(r => r.Users).WithRequired(u => u.Role).HasForeignKey(u => u.RoleId).WillCascadeOnDelete(false);
        }
    }
}
