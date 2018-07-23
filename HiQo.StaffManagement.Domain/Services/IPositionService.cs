using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Domain.Services
{
    public interface IPositionService
    {
        IEnumerable<PositionDto> GetById(int id);
        IEnumerable<PositionDto> GetByName(string name);
        IEnumerable<UserDto> GetUsers(string name);
    }
}
