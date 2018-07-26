using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.WEB.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionService _service;

        public PositionController(IPositionService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            return View(_service.GetAll());
        }
    }
}