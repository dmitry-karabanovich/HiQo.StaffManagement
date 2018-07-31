using System;
using System.Web.Mvc;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.WEB.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _service;

        public DepartmentController(IDepartmentService service)
        {
            _service = service ?? throw new ArgumentNullException();
        }

        public ActionResult Index()
        {
            return View(_service.GetAll());
        }
    }
}