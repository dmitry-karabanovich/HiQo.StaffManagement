﻿using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Domain.Services
{
    public interface IDepartmentService
    {
        IEnumerable<DepartmentDto> GetById(int id);
        IEnumerable<DepartmentDto> GetByName(string name);
        IEnumerable<CategoryDto>GetCategories(string name);
        IEnumerable<UserDto> GetUsers(string name);
    }
}
