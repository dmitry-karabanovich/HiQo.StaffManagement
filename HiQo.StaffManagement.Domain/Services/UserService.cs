using System;
using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _userRepository.GetAll<UserDto>();
        }

        public UserDto GetById(int id)
        {
            return _userRepository.GetById<UserDto>(id);
        }

        public IEnumerable<UserDto> GetByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetByLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetByRole(string role)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetByDepertment(string depertment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetByPosition(string position)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetByBirthDate(DateTime bithDate)
        {
            throw new NotImplementedException();
        }

        public void Update(UserDto user)
        {
            _userRepository.Update(user);
        }

        public void Create(UserDto user)
        {
            _userRepository.Add(user);
        }
    }
}
