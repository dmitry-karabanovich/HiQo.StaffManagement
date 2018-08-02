using System;
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
            _repository = repository ?? throw new ArgumentNullException();
        }

        public IEnumerable<PositionDto> GetAll()
        {
            return _repository.GetAll<PositionDto>();
        }

        public PositionDto GetById(int id)
        {
            return _repository.GetById<PositionDto>(id);
        }

        public PositionDto GetByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserDto> GetUsers(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
