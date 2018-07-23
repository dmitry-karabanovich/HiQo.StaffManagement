using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQo.StaffManagement.Domain.Use_Case
{
    public interface IDepartmentService<TEntity> : IService<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetByName(string name);
        void GetCategories<T>(string name);
    }
}
