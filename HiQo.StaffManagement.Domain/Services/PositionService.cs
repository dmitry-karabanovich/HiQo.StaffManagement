using System.Collections.Generic;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.Domain.Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _repository;

        public PositionService(IPositionRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<PositionDto> GetAll()
        {
            return _repository.GetAll<PositionDto>();
        }

        public IEnumerable<PositionDto> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PositionDto> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserDto> GetUsers(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
