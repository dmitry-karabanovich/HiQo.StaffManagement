using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.Domain.Services
{
    public class PositionLevelService : IPositionLevelService
    {
        private readonly IPositionLevelRepository _positionLevelRepository;

        public PositionLevelService(IPositionLevelRepository positionLevelRepository)
        {
            _positionLevelRepository = positionLevelRepository;
        }

        public IEnumerable<PositionLevelDto> GetAll()
        {
            return _positionLevelRepository.GetAll<PositionLevelDto>();
        }

        IEnumerable<PositionLevelDto> IPositionLevelService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<PositionLevelDto> IPositionLevelService.GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> GetUsers(string name)
        {
            throw new NotImplementedException();
        }
    }
}
