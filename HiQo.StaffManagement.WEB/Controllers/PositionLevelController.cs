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
    public class PositionLevelController : Controller
    {
        // GET: PositionLevel
        public ActionResult Index()
        {
            IEnumerable<PositionLevelDto> positionLevels;
            using (CompanyContext context = new CompanyContext())
            {
                IPositionLevelRepository repository = new PositionLevelRepository(context);
                IPositionLevelService service = new PositionLevelService(repository);
                positionLevels = service.GetAll();
            }
            return View(positionLevels);
        }
    }
}