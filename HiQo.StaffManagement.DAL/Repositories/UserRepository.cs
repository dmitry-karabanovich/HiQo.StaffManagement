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
    public class UserRepository : BasePepository, IUserRepository
    {
        private readonly DbSet<User> _dbSet;

        public UserRepository(CompanyContext context) : base(context)
        {
            _dbSet = context.Set<User>();
        }

        public void Add<TDto>(TDto entityDto) where TDto : class
        {
            var entity = Mapper.Map<TDto, User>(entityDto);
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Remove(object id)
        {
            var entityToDelete = _dbSet.Find(id);
            Remove(entityToDelete);
        }

        public void Remove<TDto>(TDto entityToDelete) where TDto : class
        {
            throw new NotImplementedException();
            //if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
            //    (_dbSet).Attach(entityToDelete);

            //(_dbSet as DbSet<TEntity>).Remove(entityToDelete);
        }

        public IEnumerable<TDto> GetAll<TDto>() where TDto : class
        {
            var users = _dbSet.ToList() as IEnumerable<User>;
            return Mapper.Map<IEnumerable<User>, IEnumerable<TDto>>(users);
        }

        public IEnumerable<TDto> GetByName<TDto>() where TDto : class
        {
            throw new NotImplementedException();
        }
      
        public void Update<TDto>(TDto entity) where TDto : class
        {
            throw new NotImplementedException();
            //(_dbSet as DbSet<TEntity>).Attach(entity);
            //_dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}