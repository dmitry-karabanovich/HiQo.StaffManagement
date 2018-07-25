using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Services.Interface;


namespace HiQo.StaffManagement.WEB.Controllers
{
    public class PositionLevelController : Controller
    {
        private readonly IPositionLevelService _service;

        public PositionLevelController(IPositionLevelService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            return View(_service.GetAll());
        }
    }
}