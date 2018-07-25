using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class PositionRepository : BaseRepository<>, IPositionRepository
    {
        private readonly DbSet<Position> _dbSet;

        public PositionRepository(CompanyContext context) : base(context)
        {
            _dbSet = context.Set<Position>();
        }

        public IEnumerable<TDto> GetAll<TDto>() where TDto : class
        {
            var positions = _dbSet.ToList() as IEnumerable<Position>;
            return Mapper.Map<IEnumerable<Position>, IEnumerable<TDto>>(positions);
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
