using System;
using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.Domain.Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IEnumerable<DepartmentDto> GetAll()
        {
           return _departmentRepository.GetAll<DepartmentDto>();
        }

        public IEnumerable<DepartmentDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepartmentDto> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDto> GetCategories(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetUsers(string name)
        {
            throw new NotImplementedException();
        }
    }
}
