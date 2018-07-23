using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services;

namespace HiQo.StaffManagement.DAL.Services
{
    class UserService : IUserService
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

        public UserDto GetById()
        {
            throw new NotImplementedException();
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
    }
}
