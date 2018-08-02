using System;
using System.Web;
using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.WEB.Controllers
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

        public ActionResult GetUserProfile(int userId)
        {
            return View("UserProfile", _service.GetById(userId));
        }
    }
}