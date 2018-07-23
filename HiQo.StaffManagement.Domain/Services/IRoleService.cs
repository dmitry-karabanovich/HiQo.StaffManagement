using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Domain.Services
{
   public interface IRoleService
    {
        IEnumerable<RoleDto> GetByName(string name);
        IEnumerable<RoleDto> GetById(int id);
        IEnumerable<UserDto> GetUsers(string name);
    }
}
