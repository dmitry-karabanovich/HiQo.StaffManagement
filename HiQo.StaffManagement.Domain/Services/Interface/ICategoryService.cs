using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Domain.Services.Interface
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();
        CategoryDto GetById(int id);
        IEnumerable<CategoryDto> GetBeName(string name);
        IEnumerable<PositionDto> GetPositions(string name);
        IEnumerable<UserDto> GetUsers(string name);

    }
}
