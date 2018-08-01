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
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly DbSet<User> _dbSet;

        public UserRepository(CompanyContext context) : base(context)
        {
            context.Configuration.LazyLoadingEnabled = false;
            _dbSet = context.Set<User>();
        }

        public TDto GetById<TDto>(int id) where TDto : class
        {
           return Mapper.Map<User, TDto>(_dbSet.Include(_ => _.Category).Include(_ => _.Department).Include(_ => _.Position).Include(_ => _.PositionLevel).Include(_ => _.Role).FirstOrDefault(_ => _.UserId == id));
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

        public void Remove(int id)
        {
            var entityToDelete = _dbSet.Find(id);
            Remove(entityToDelete);
        }

        public virtual void Remove<TDto>(TDto entityToDelete) where TDto : class
        {
            var uswerToDelete = Mapper.Map<User>(entityToDelete);
            if (DbContext.Entry(entityToDelete).State == EntityState.Detached)
                (_dbSet).Attach(uswerToDelete);

            _dbSet.Remove(uswerToDelete);
        }

        public IEnumerable<TDto> GetAll<TDto>() where TDto : class
        {
            var ua = _dbSet.ToList();
            var users = (_dbSet.Include(_ => _.Category).Include(_ => _.Department).Include(_ => _.Position).Include(_ => _.PositionLevel).Include(_ => _.Role).ToList()) as IEnumerable<User>;
            users.First().UserId = 100;
            return Mapper.Map<IEnumerable<User>, IEnumerable<TDto>>(users);
        }

        public IEnumerable<TDto> GetByName<TDto>() where TDto : class
        {
            throw new NotImplementedException();
        }
      
    }
}