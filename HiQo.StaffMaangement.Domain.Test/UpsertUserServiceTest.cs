using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services;
using HiQo.StaffManagement.Domain.Services.Interface;
using Xunit;

namespace HiQo.StaffMaangement.Domain.Test
{
    public class UpsertUserServiceTest
    {
        private readonly IDepartmentRepository _department;
        private readonly ICategoryRepository _category;
        private readonly IPositionRepository _position;
        private readonly IPositionLevelRepository _positionLevel;
        private readonly IRoleRepository _role;
        private readonly IUpsertUserService _upsertUserService;

        public UpsertUserServiceTest()
        {
            _department = A.Fake<IDepartmentRepository>();
            _category = A.Fake<ICategoryRepository>();
            _position = A.Fake<IPositionRepository>();
            _positionLevel = A.Fake<IPositionLevelRepository>();
            _role = A.Fake<IRoleRepository>();
            _upsertUserService = new UpsertUserService(_department, _category, _position, _positionLevel, _role);
        }

        [Fact]
        public void GetSharedInfoDto()
        {
            IEnumerable<DepartmentDto> department = new[] {new DepartmentDto {DepartmentDtoId = 1}};
            IEnumerable<CategoryDto> category = new[] {new CategoryDto {CategoryDtoId = 1}};
            IEnumerable<PositionDto> position = new[] {new PositionDto {PositionDtoId = 1}};
            IEnumerable<PositionLevelDto> positionLevel = new[] {new PositionLevelDto {PositionLevelDtoId = 1}};
            IEnumerable<RoleDto> role = new[] {new RoleDto {RoleDtoId = 1}};

            var expectedDepartmentIds = new[] {1};
            var expectedCategoryIds = new[] {1};
            var expectedPositionIds = new[] {1};
            var expectedPositionLevelIds = new[] {1};
            var expectedRoleIds = new[] {1};

            A.CallTo(() => _department.GetAll<DepartmentDto>()).Returns(department);
            A.CallTo(() => _category.GetAll<CategoryDto>()).Returns(category);
            A.CallTo(() => _position.GetAll<PositionDto>()).Returns(position);
            A.CallTo(() => _positionLevel.GetAll<PositionLevelDto>()).Returns(positionLevel);
            A.CallTo(() => _role.GetAll<RoleDto>()).Returns(role);

            var sharedInfo = _upsertUserService.GetSharedInfoDto();

            for (var i = 0; i < expectedDepartmentIds.Length; i++)
            {
                Assert.Equal((sharedInfo.DepartmentDtos.ToList())[i].DepartmentDtoId, expectedDepartmentIds[i]);
            }

            for (var i = 0; i < expectedCategoryIds.Length; i++)
            {
                Assert.Equal((sharedInfo.CategoryDtos.ToList())[i].CategoryDtoId, expectedCategoryIds[i]);
            }

            for (var i = 0; i < expectedPositionIds.Length; i++)
            {
                Assert.Equal((sharedInfo.PositionDtos.ToList())[i].PositionDtoId, expectedPositionIds[i]);
            }

            for (var i = 0; i < expectedPositionLevelIds.Length; i++)
            {
                Assert.Equal((sharedInfo.PositionLevelDtos.ToList())[i].PositionLevelDtoId, expectedPositionLevelIds[i]);
            }

            for (var i = 0; i < expectedRoleIds.Length; i++)
            {
                Assert.Equal((sharedInfo.RoleDtos.ToList())[i].RoleDtoId, expectedRoleIds[i]);
            }


        }
    }
}