using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HiQo.StaffManagement.Domain.Repositories
{
    public interface IRepository 
    {
        IEnumerable<TDto> GetAll<TDto>() where TDto : class;
        IEnumerable<TDto> GetByName<TDto>() where TDto : class;
        void Add<TDto>(TDto entity) where TDto : class;
        void Remove<TDto>(TDto entity) where TDto : class;
        void Update<TDto>(TDto entity) where TDto : class;
    }
}