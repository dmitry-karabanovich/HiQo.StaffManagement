using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.WEB.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            return View(_service.GetAll());
        }
    }
}