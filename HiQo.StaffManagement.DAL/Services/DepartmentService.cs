using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Entities;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Services;

namespace HiQo.StaffManagement.DAL.Services
{
    class DepartmentService:IDepartmentService
    {
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
    }
}
