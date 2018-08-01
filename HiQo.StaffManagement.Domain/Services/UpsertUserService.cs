using System;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.Domain.Services
{
    public class UpsertUserService : IUpsertUserService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPositionRepository _positionRepository;
        private readonly IPositionLevelRepository _positionLevelRepository;
        private readonly IRoleRepository _roleRepository;

        public UpsertUserService(IDepartmentRepository departmentRepository, ICategoryRepository categoryRepository, IPositionRepository positionRepository, IPositionLevelRepository positionLevelRepository, IRoleRepository roleRepository)
        {
            _departmentRepository = departmentRepository ?? throw new ArgumentNullException();
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException();
            _positionRepository = positionRepository ?? throw new ArgumentNullException();
            _positionLevelRepository = positionLevelRepository ?? throw new ArgumentNullException();
            _roleRepository = roleRepository ?? throw new ArgumentNullException();
        }

        public SharedInfoDto GetSharedInfoDto()
        {
            var sharedInfo =
                new SharedInfoDto
                {
                    DepartmentDtos = _departmentRepository.GetAll<DepartmentDto>(),
                    CategoryDtos = _categoryRepository.GetAll<CategoryDto>(),
                    PositionDtos = _positionRepository.GetAll<PositionDto>(),
                    PositionLevelDtos = _positionLevelRepository.GetAll<PositionLevelDto>(),
                    RoleDtos = _roleRepository.GetAll<RoleDto>()
                };
            return sharedInfo;
        }
    }
}
