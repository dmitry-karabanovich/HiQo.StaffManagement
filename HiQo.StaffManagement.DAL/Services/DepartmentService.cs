using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.DataBase.Models;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.Use_Case;
namespace HiQo.StaffManagement.DAL.Services
{
    class DepartmentService:IDepartmentService<Department>
    {
        public IEnumerable<Department> GetAll()
        {
           
        }

        public Department GetById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetByName(string name)
        {
            throw new NotImplementedException();
        }

    }
}
