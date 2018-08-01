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
    public class PositionLevelServiceTest
    {
        private readonly IPositionLevelRepository _positionLevel;
        private readonly IPositionLevelService _positionLevelService;

        public PositionLevelServiceTest()
        {
            _positionLevel = A.Fake<IPositionLevelRepository>();
            _positionLevelService = new PositionLevelService(_positionLevel);
        }

        [Fact]
        public void GetAll()
        {
            IEnumerable<PositionLevelDto> positionLevels = new PositionLevelDto[] { new PositionLevelDto() { PositionLevelDtoId = 1 }, new PositionLevelDto() { PositionLevelDtoId = 2 } };
            var expectedIds = new[] { 1, 2 };
            A.CallTo(() => _positionLevel.GetAll<PositionLevelDto>()).Returns(positionLevels);

            var expectedPositionLevels = _positionLevelService.GetAll().ToList();

            Assert.Equal(expectedIds.Length, expectedPositionLevels.Count);

            for (var i = 0; i < expectedIds.Length; i++)
            {
                Assert.Equal(expectedPositionLevels[i].PositionLevelDtoId, expectedIds[i]);
            }
        }
    }
}
