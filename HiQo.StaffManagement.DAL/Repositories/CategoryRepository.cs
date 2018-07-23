using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class CategoryRepository : BasePepository<Category>, ICategoryRepository 
    {
        public CategoryRepository(CompanyContext context) : base(context)
        {
        }
    }
}
