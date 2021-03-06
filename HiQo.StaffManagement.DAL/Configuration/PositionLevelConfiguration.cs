﻿using System.Data.Entity.ModelConfiguration;
using HiQo.StaffManagement.DAL.DataBase.Entities;

namespace HiQo.StaffManagement.DAL.Configuration
{
    public class PositionLevelConfiguration : EntityTypeConfiguration<PositionLevel>
    {
        public PositionLevelConfiguration()
        {
            Property(g => g.Name).IsRequired().HasMaxLength(30);
            HasMany(r => r.Users).WithRequired(u => u.PositionLevel).HasForeignKey(u => u.PositionLevelId).WillCascadeOnDelete(false);
        }
    }
}
