using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class RoleRepository : BasePepository<Role>, IRoleRepository 
    {
        public RoleRepository(CompanyContext context) : base(context)
        {
        }
    }
}
