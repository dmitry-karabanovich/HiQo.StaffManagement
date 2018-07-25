using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class UserRepository : BasePepository, IUserRepository
    {
        private readonly DbSet<User> _dbSet;

        public UserRepository(CompanyContext context) : base(context)
        {
            context.Configuration.LazyLoadingEnabled = false;
            _dbSet = context.Set<User>();
        }

        public TDto GetById<TDto>() where TDto : class
        {
            throw new NotImplementedException();
        }

        public void Add<TDto>(TDto entityDto) where TDto : class
        {
            var entity = Mapper.Map<TDto, User>(entityDto);
            _dbSet.Add(entity);
            DbContext.SaveChanges();
        }

        public void Update<TDto>(TDto entityDto) where TDto : class
        {
            var entity = Mapper.Map<TDto, User>(entityDto);
            _dbSet.Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.SaveChanges();
        }

        public virtual void Remove(int id)
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
            var users = (_dbSet.Include(_ => _.Category).Include(_ => _.Department).Include(_ => _.Position).Include(_ => _.PositionLevel).Include(_ => _.Role).ToList()) as IEnumerable<User>;
            return Mapper.Map<IEnumerable<User>, IEnumerable<TDto>>(users);
        }

        public IEnumerable<TDto> GetByName<TDto>() where TDto : class
        {
            throw new NotImplementedException();
        }
      
    }
}