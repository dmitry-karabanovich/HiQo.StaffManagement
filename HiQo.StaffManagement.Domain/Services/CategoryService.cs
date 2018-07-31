using System;
using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException();
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            return _repository.GetAll<CategoryDto>();
        }

        public IEnumerable<CategoryDto> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CategoryDto> GetBeName(string name)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PositionDto> GetPositions(string name)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserDto> GetUsers(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
