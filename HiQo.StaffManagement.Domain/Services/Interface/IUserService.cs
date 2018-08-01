using System;
using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;

namespace HiQo.StaffManagement.Domain.Services.Interface
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAll();
        UserDto GetById(int id);
        IEnumerable<UserDto> GetByFirstName(string firstName);
        IEnumerable<UserDto> GetByLastName(string lastName);
        IEnumerable<UserDto> GetByRole(string role);
        IEnumerable<UserDto> GetByDepertment(string depertment);
        IEnumerable<UserDto> GetByCategory(string category);
        IEnumerable<UserDto> GetByPosition(string position);
        IEnumerable<UserDto> GetByBirthDate(DateTime bithDate);
        void Update(UserDto user);
        void Create(UserDto user);
        void Remove(int userId);
    }
}
