using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Domain.Services.Interface
{
    public interface IPositionLevelService
    {
        IEnumerable<PositionLevelDto> GetAll();
        IEnumerable<PositionLevelDto> GetById(int id);
        IEnumerable<PositionLevelDto> GetByName(string name);
        IEnumerable<UserDto> GetUsers(string name);
    }
}
