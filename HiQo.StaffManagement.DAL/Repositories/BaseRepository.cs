using System;
using System.Data.Entity;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly DbContext DbContext;
        protected BaseRepository(DbContext context)
        {
            DbContext = context ?? throw new ArgumentNullException();
        }
    }
}