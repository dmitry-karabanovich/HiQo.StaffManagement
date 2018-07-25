using System.Collections.Generic;
using System.Web.Mvc;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services.Interface;
using HiQo.StaffManagement.Domain.Services;

namespace HiQo.StaffManagement.WEB.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<UserDto> users;
            using (CompanyContext context = new CompanyContext())
            {
                IUserRepository repository = new UserRepository(context);
                IUserService userService = new UserService(repository);
                users = userService.GetAll();
            }
            return View(users);
        }
    }
}