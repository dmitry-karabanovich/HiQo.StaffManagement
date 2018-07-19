using System.Data.Entity;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class PositionLevelRepository : BasePepository<PositionLevel>, IPositionLevelRepository
    {
        public PositionLevelRepository(DbContext context) : base(context)
        {
        }
    }
}
