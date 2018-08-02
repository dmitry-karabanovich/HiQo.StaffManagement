using System.Web;
using System.Web.Mvc;

namespace HiQo.StaffManagement.WEB.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult HttpError404(string message)
        {
            ViewBag.Error = message;
            return View("HttpError404");
        }
    }
}