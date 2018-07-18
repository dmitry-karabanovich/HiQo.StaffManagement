using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Models;

namespace HiQo.StaffManagement.DAL.Configuration
{
    class PositionLevelConfiguration : EntityTypeConfiguration<PositionLevel>
    {
        public PositionLevelConfiguration()
        {
            Property(g => g.Name).IsRequired().HasMaxLength(30);
            HasMany(r => r.Users).WithRequired(u => u.PositionLevel).HasForeignKey(u => u.PositionLevelId).WillCascadeOnDelete(false);
        }
    }
}
