using System;
using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.Use_Case
{
    public interface IUserService
    {
        IEnumerable<TEntity> GetAll<TEntity>() where TEntity : class;
        TEntity GetById<TEntity>() where TEntity : class;
        IEnumerable<TEntity> GetByFirstName<TEntity>(string firstName) where TEntity : class;
        IEnumerable<TEntity> GetByLastName<TEntity>(string lastName) where TEntity : class;
        IEnumerable<TEntity> GetByRole<TEntity>(string role) where TEntity : class;
        IEnumerable<TEntity> GetByDepertment<TEntity>(string depertment) where TEntity : class;
        IEnumerable<TEntity> GetByCategory<TEntity>(string category) where TEntity : class;
        IEnumerable<TEntity> GetByPosition<TEntity>(string position) where TEntity : class;
        IEnumerable<TEntity> GetByBirthDate<TEntity>(DateTime bithDate) where TEntity : class;
    }
}
