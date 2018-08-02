using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Xunit;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffMaangement.Domain.Test
{
    public class DepartmentServiceTest
    {
        private readonly IDepartmentRepository _department;
        private readonly IDepartmentService _departmentService;

        public DepartmentServiceTest()
        {
            _department = A.Fake<IDepartmentRepository>();
            _departmentService = new DepartmentService(_department);
        }

        [Fact]
        public void GetById()
        {
            const int departmentId = 1;
            var department = new DepartmentDto() { DepartmentDtoId = departmentId };
            A.CallTo(() => _department.GetById<DepartmentDto>(departmentId)).Returns(department);

            var returnsUser = _departmentService.GetById(departmentId);

            Assert.Equal(departmentId, returnsUser.DepartmentDtoId);
        }

        [Fact]
        public void GetAll()
        {
            IEnumerable<DepartmentDto> departments = new DepartmentDto[]{new DepartmentDto(){DepartmentDtoId = 1}, new DepartmentDto(){DepartmentDtoId = 2}};
            var expectedIds = new[] {1, 2};
            A.CallTo(() => _department.GetAll<DepartmentDto>()).Returns(departments);

            var expecteddepartments = _departmentService.GetAll().ToList();

            Assert.Equal(expectedIds.Length, expecteddepartments.Count);

            for (var i = 0; i <expectedIds.Length ; i++)
            {
                Assert.Equal(expecteddepartments[i].DepartmentDtoId,expectedIds[i]);
            }
        }

        [Fact]
        public void Create()
        {
            var department = new DepartmentDto() { DepartmentDtoId = 1 };

            _departmentService.Create(department);

            A.CallTo(() => _department.Add(department)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void Update()
        {
            var department = new DepartmentDto() { DepartmentDtoId = 1 };

            _departmentService.Update(department);

            A.CallTo(() => _department.Update(department)).MustHaveHappenedOnceExactly();
        }
    }
}
