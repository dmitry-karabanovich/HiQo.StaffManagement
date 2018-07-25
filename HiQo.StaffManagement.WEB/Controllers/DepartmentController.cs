using System.Collections.Generic;
using System.Web.Mvc;
using HiQo.StaffManagement.DAL.DataBase;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.EntitiesDto;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Services;
using HiQo.StaffManagement.Domain.Services.Interface;

namespace HiQo.StaffManagement.WEB.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Depertment
        public ActionResult Index()
        {
            IEnumerable<DepartmentDto> departments;
            using (CompanyContext context = new CompanyContext())
            {
                IDepartmentRepository departmentRepository = new DepartmentRepository(context);
                IDepartmentService service = new DepartmentService(departmentRepository);
                departments = service.GetAll();
            }
            return View(departments);
        }
    }
}