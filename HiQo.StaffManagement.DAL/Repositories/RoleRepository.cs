﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.Domain.Repositories;

namespace HiQo.StaffManagement.DAL.Repositories
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        private readonly DbSet<Role> _dbSet;

        public RoleRepository(CompanyContext context) : base(context)
        {
            _dbSet = context.Set<Role>();
        }

        public void Add<TDto>(TDto entity) where TDto : class
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Remove<TDto>(TDto entity) where TDto : class
        {
            throw new System.NotImplementedException();
        }

        public void Update<TDto>(TDto entity) where TDto : class
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TDto> GetAll<TDto>() where TDto : class
        {
            var roles = _dbSet.ToList() as IEnumerable<Role>;
            return Mapper.Map<IEnumerable<Role>, IEnumerable<TDto>>(roles);
        }

        public IEnumerable<TDto> GetByName<TDto>() where TDto : class
        {
            throw new System.NotImplementedException();
        }

        public TDto GetById<TDto>(int id) where TDto : class
        {
            throw new System.NotImplementedException();
        }

    }
}
