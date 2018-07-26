using System.Web.Mvc;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.WEB.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            return View(_service.GetAll());
        }

        public ActionResult GetUserProfile(int userId)
        {
            return View("UserProfile", _service.GetById(userId));
        }

        public ActionResult UpdateUser(int userId)
        {
            return View("UpdateUser", _service.GetById(userId));
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