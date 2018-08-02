using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class DepartmentRepository : BaseRepository, IDepartmentRepository
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

        public TDto GetById<TDto>(int id) where TDto : class
        {
            return Mapper.Map<Department, TDto>(_dbSet.FirstOrDefault(_ => _.DepartmentId == id));
        }

        public void Add<TDto>(TDto entityDto) where TDto : class
        {
            var entity = Mapper.Map<TDto, Department>(entityDto);
            _dbSet.Add(entity);
            DbContext.SaveChanges();
        }


        public void Update<TDto>(TDto entityDto) where TDto : class
        {
            var entity = Mapper.Map<TDto, Department>(entityDto);
            _dbSet.Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.SaveChanges();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove<TDto>(TDto entity) where TDto : class
        {
            throw new System.NotImplementedException();
        }
    }
}
