using System.Collections.Generic;

namespace HiQo.StaffManagement.Domain.Repositories
{
    public interface IRepository
    {
        IEnumerable<TDto> GetAll<TDto>() where TDto : class;
        IEnumerable<TDto> GetByName<TDto>() where TDto : class;
        TDto GetById<TDto>(int id) where TDto : class;
        void Add<TDto>(TDto entity) where TDto : class;
        void Remove(int id);
        void Update<TDto>(TDto entity) where TDto : class;
    }
}