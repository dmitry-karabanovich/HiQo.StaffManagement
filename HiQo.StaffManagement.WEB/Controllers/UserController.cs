using System.Collections.Generic;
using System.Web.Mvc;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Services.Interface;
using AutoMapper;
using HiQo.StaffManagement.Core.Models;

namespace HiQo.StaffManagement.WEB.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;
        private readonly IUpsertUserService _upsertUserService;

        public UserController(IUserService service, IUpsertUserService upsertUserService)
        {
            _service = service;
            _upsertUserService = upsertUserService;
        }

        public ActionResult Index()
        {
            return View(_service.GetAll());
        }

        public ActionResult GetUserProfile(int userId)
        {
            return View("UserProfile",_service.GetById(userId));
        }

        public ActionResult UpdateUser(int userId)
        {
            var info = _upsertUserService.GetSharedInfoDto();
            var departmentList = new SelectList(info.DepartmentDtos,"DepartmentDtoId","Name");
            var categoryList = new SelectList(info.CategoryDtos,"CategoryDtoId","Name");
            var positionList = new SelectList(info.PositionDtos,"PositionDtoId","Name");
            var positionLevelList = new SelectList(info.PositionLevelDtos,"PositionLevelDtoId","Name");
            ViewBag.Departments = departmentList;
            ViewBag.Category = categoryList;
            ViewBag.Position = positionList;
            ViewBag.PositionLevel = positionLevelList;
            return View("UpdateUser", Mapper.Map<UserDto,UpsertUser>(_service.GetById(userId)));
        }

        public ViewResult Create()
        {
            return View("UpdateUser", null);
        }

        [HttpPost]
        public ActionResult EditUser(UserDto user)
        {

            return View();
        }
    }
}