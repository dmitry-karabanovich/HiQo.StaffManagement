using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Models;

namespace HiQo.StaffManagement.DAL.Configuration
{
    class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            Property(g => g.Name).IsRequired().HasMaxLength(20);
            HasMany(r => r.Users).WithRequired(u => u.Role).HasForeignKey(u => u.RoleId).WillCascadeOnDelete(false);
        }
    }
}
