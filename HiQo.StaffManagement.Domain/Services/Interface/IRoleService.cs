﻿using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Domain.Services.Interface
{
   public interface IRoleService
    {
        IEnumerable<UserDto> GetAll();
        IEnumerable<RoleDto> GetByName(string name);
        IEnumerable<RoleDto> GetById(int id);
        IEnumerable<UserDto> GetUsers(string name);
    }
}
