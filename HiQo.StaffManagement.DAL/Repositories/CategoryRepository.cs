using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        private readonly DbSet<Category> _dbSet;
        public CategoryRepository(CompanyContext context) : base(context)
        {
            _dbSet = context.Set<Category>();
        }

        public IEnumerable<TDto> GetAll<TDto>() where TDto : class
        {
            var categories = (_dbSet.Include(_=> _.Department).ToList()) as IEnumerable<Category>;
            return Mapper.Map<IEnumerable<Category>, IEnumerable<TDto>>(categories);
        }

        public IEnumerable<TDto> GetByName<TDto>() where TDto : class
        {
            throw new System.NotImplementedException();
        }

        public TDto GetById<TDto>(int id) where TDto : class
        {
            throw new System.NotImplementedException();
        }

        public void Add<TDto>(TDto entity) where TDto : class
        {
            throw new System.NotImplementedException();
        }

        public void Remove<TDto>(TDto entity) where TDto : class
        {
            throw new System.NotImplementedException();
        }

        public void Update<TDto>(TDto entity) where TDto : class
        {
            throw new System.NotImplementedException();
        }
    }
}
