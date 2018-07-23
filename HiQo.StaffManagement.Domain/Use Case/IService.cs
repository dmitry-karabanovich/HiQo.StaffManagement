using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.Use_Case
{
    public interface IService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById();
    }
}
