using System.Collections.Generic;
using System.Linq;
using Xunit;
using FakeItEasy;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffMaangement.Domain.Test
{
    public class UserServiceTest
    {
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        public UserServiceTest()
        {
            _userRepository = A.Fake<IUserRepository>();
            _userService = new UserService(_userRepository);
        }

        [Fact]
        public void GetById_user_returnsUser()
        {
            const int userId = 1;
            var user = new UserDto(){UserDtoId = userId};
            A.CallTo(() => _userRepository.GetById<UserDto>(userId)).Returns(user);

            var returnsUser = _userService.GetById(userId);

            Assert.Equal(userId, returnsUser.UserDtoId);
        }

        [Fact]
        public void GetAll_ReturnsUserList()
        {
            IEnumerable<UserDto> users = new[] {new UserDto(){UserDtoId = 1}, new UserDto(){UserDtoId = 2}};
            var expectedIds = new[] { 1, 2};
            A.CallTo(() => _userRepository.GetAll<UserDto>()).Returns(users);
            
            var testUsers = _userService.GetAll().ToList();
            Assert.Equal(expectedIds.Length,testUsers.Count); 
            for (var i = 0; i < expectedIds.Length; i++)
            {
                Assert.Equal(expectedIds[i],testUsers[i].UserDtoId);
            }

         }

        [Fact]
        public void Create()
        {
            var user = new UserDto(){UserDtoId = 1};

            _userService.Create(user);

            A.CallTo(() => _userRepository.Add(user)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Update()
        {
            var user = new UserDto() { UserDtoId = 1 };

            _userService.Update(user);

            A.CallTo(() => _userRepository.Update(user)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Remove()
        {
            const int id = 1;

            _userService.Remove(id);

            A.CallTo(() => _userRepository.Remove(id)).MustHaveHappenedOnceExactly();
        }
    }
}
