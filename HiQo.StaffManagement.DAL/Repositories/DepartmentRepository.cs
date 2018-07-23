using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class DepartmentRepository : BasePepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(CompanyContext context) : base(context)
        {
        }
    }
}
