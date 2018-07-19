using System.Data.Entity;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class PositionRepository : BasePepository<Position>, IPositionRepository
    {
        public PositionRepository(DbContext context) : base(context)
        {
        }
    }
}
