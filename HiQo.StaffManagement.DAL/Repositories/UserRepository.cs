using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CompanyContext _dbContext;
        private readonly DbSet<User> _dbSet;

        public UserRepository(CompanyContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<User>();
        }

        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : class
        {
            return (_dbSet as DbSet<TEntity>).ToList();
        }

        public IEnumerable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null) where TEntity : class
        {
            IQueryable<TEntity> query = _dbSet as DbSet<TEntity>;
            if (filter != null) query = query.Where(filter);
            return orderBy != null ? orderBy(query).ToList() : query.ToList();
        }

        public void Add<TEntity>(TEntity entity) where TEntity : class
        {
            (_dbSet as DbSet<TEntity>).Add(entity);
            _dbContext.SaveChanges();
        }

        public void Remove<TEntity>(TEntity entityToDelete) where TEntity : class
        {
            if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
                (_dbSet as DbSet<TEntity>).Attach(entityToDelete);

            (_dbSet as DbSet<TEntity>).Remove(entityToDelete);
        }

        public void Update<TEntity>(TEntity entity) where TEntity : class
        {
            (_dbSet as DbSet<TEntity>).Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Remove(object id)
        {
            var entityToDelete = _dbSet.Find(id);
            Remove(entityToDelete);
        }
    }
}