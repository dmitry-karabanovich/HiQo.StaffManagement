using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class PositionLevelRepository : BasePepository<PositionLevel>, IPositionLevelRepository
    {
        public PositionLevelRepository(CompanyContext context) : base(context)
        {
        }
    }
}
