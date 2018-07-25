using System.Data.Entity;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public abstract class BasePepository
    {
        protected readonly DbContext DbContext;
        protected BasePepository(DbContext context)
        {
            DbContext = context;
        }
    }
}

//_dbSet = context.Set<TEntity>();

//public virtual void Add(TEntity entity)
//{
//    _dbSet.Add(entity);
//    _dbContext.SaveChanges();
//}

//public virtual void Remove(TEntity entityToDelete)
//{
//    if (_dbContext.Entry(entityToDelete).State == EntityState.Detached) _dbSet.Attach(entityToDelete);
//    _dbSet.Remove(entityToDelete);
//    _dbContext.SaveChanges();
//}

//public virtual void Update(TEntity entity)
//{
//    _dbSet.Attach(entity);
//    _dbContext.Entry(entity).State = EntityState.Modified;
//    _dbContext.SaveChanges();
//}

//public virtual IEnumerable<TEntity> GetAll()
//{
//    return _dbSet.AsNoTracking().ToList();
//}
////GetByName
////GetById

//public virtual void Remove(object id)
//{
//    var entityToDelete = _dbSet.Find(id);
//    Remove(entityToDelete);
//}