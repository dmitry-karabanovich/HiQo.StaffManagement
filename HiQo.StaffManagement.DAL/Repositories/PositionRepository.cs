using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class PositionRepository : BasePepository<Position>, IPositionRepository
    {
        public PositionRepository(CompanyContext context) : base(context)
        {
        }
    }
}
