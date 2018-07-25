using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class DepartmentRepository : BaseRepository<>, IDepartmentRepository
    {
        private readonly DbSet<Department> _dbSet;

        public DepartmentRepository(CompanyContext context) : base(context)
        {
            _dbSet = context.Set<Department>();
        }

        public IEnumerable<TDto> GetAll<TDto>() where TDto : class
        {
            var departments = _dbSet.ToList() as IEnumerable<Department>;
            return Mapper.Map<IEnumerable<Department>, IEnumerable<TDto>>(departments);
        }

        public IEnumerable<TDto> GetByName<TDto>() where TDto : class
        {
            throw new System.NotImplementedException();
        }

        public TDto GetById<TDto>() where TDto : class
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
