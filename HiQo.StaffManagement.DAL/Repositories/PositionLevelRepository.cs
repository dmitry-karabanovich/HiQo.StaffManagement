using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class PositionLevelRepository : BaseRepository, IPositionLevelRepository
    {
        private readonly DbSet<PositionLevel> _dbSet;

        public PositionLevelRepository(CompanyContext context) : base(context)
        {
            _dbSet = context.Set<PositionLevel>();
        }

        public IEnumerable<TDto> GetAll<TDto>() where TDto : class
        {
            var positionLevels = _dbSet.ToList() as IEnumerable<PositionLevel>;
            return Mapper.Map<IEnumerable<PositionLevel>, IEnumerable<TDto>>(positionLevels);
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

        public void Remove(int id)
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
