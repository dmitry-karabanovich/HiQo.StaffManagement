using System;
using System.Web.Mvc;
using AutoMapper;
using HiQo.StaffManagement.Core.Models;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.WEB.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;
        private readonly IUpsertUserService _upsertUserService;

        public UserController(IUserService service, IUpsertUserService upsertUserService)
        {
            _service = service ?? throw new ArgumentNullException();
            _upsertUserService = upsertUserService ?? throw new ArgumentNullException();
        }

        public ActionResult Index()
        {
            return View(_service.GetAll());
        }

        public ActionResult UpdateUser(int userId)
        {
            var info = _upsertUserService.GetSharedInfoDto();
            var departmentList = new SelectList(info.DepartmentDtos, "DepartmentDtoId", "Name");
            var categoryList = new SelectList(info.CategoryDtos, "CategoryDtoId", "Name");
            var positionList = new SelectList(info.PositionDtos, "PositionDtoId", "Name");
            var positionLevelList = new SelectList(info.PositionLevelDtos, "PositionLevelDtoId", "Name");
            var roleList = new SelectList(info.RoleDtos,"RoleDtoId","Name");
            ViewBag.Departments = departmentList;
            ViewBag.Category = categoryList;
            ViewBag.Position = positionList;
            ViewBag.PositionLevel = positionLevelList;
            ViewBag.Role = roleList;
            var user = Mapper.Map<UserDto, UpsertUser>(_service.GetById(userId));
            return View("UpsertUser", user);
        }

        public ActionResult CreateUser(int id)
        {
            var info = _upsertUserService.GetSharedInfoDto();
            var departmentList = new SelectList(info.DepartmentDtos, "DepartmentDtoId", "Name");
            var categoryList = new SelectList(info.CategoryDtos, "CategoryDtoId", "Name");
            var positionList = new SelectList(info.PositionDtos, "PositionDtoId", "Name");
            var positionLevelList = new SelectList(info.PositionLevelDtos, "PositionLevelDtoId", "Name");
            var roleList = new SelectList(info.RoleDtos, "RoleDtoId", "Name");
            ViewBag.Departments = departmentList;
            ViewBag.Category = categoryList;
            ViewBag.Position = positionList;
            ViewBag.PositionLevel = positionLevelList;
            ViewBag.Role = roleList;
            return View("UpsertUser", null);
        }

        [HttpPost]
        public ActionResult EditUser(UpsertUser upsertUser)
        {
            var user = Mapper.Map<UserDto>(upsertUser);
            if (user.UserDtoId == 0)
                _service.Create(user);
            else
                _service.Update(user);
            return View();
        }
    }
}