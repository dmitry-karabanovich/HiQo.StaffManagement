using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Domain.Services.Interface
{
    public interface IPositionService
    {
        IEnumerable<PositionDto> GetAll();
        PositionDto GetById(int id);
        PositionDto GetByName(string name);
        IEnumerable<UserDto> GetUsers(string name);
    }
}
