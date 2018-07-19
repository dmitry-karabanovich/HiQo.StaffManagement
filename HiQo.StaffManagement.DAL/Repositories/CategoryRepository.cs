using System.Data.Entity;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class CategoryRepository : BasePepository<Category>, ICategoryRepository 
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
