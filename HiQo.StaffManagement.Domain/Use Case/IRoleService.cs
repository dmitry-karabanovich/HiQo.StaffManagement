using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.Use_Case
{
   public interface IRoleService<TEntity> : IService<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetByName(string name);
    }
}
