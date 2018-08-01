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
    public class PositionServiceTest
    {
        private readonly IPositionRepository _position;
        private readonly IPositionService _positionService;

        public PositionServiceTest()
        {
            _position = A.Fake<IPositionRepository>();
            _positionService = new PositionService(_position);
        }

        [Fact]
        public void GetAll()
        {
            IEnumerable<PositionDto> positions = new PositionDto[] { new PositionDto() { PositionDtoId = 1 }, new PositionDto() { PositionDtoId = 2 } };
            var expectedIds = new[] { 1, 2 };
            A.CallTo(() => _position.GetAll<PositionDto>()).Returns(positions);

            var expectedpositions = _positionService.GetAll().ToList();

            Assert.Equal(expectedIds.Length, expectedpositions.Count);

            for (var i = 0; i < expectedIds.Length; i++)
            {
                Assert.Equal(expectedpositions[i].PositionDtoId, expectedIds[i]);
            }
        }
    }
}
