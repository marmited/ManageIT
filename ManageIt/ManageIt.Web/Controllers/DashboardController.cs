using Microsoft.AspNetCore.Mvc;

namespace ManageIt.Web.Controllers
{
    public class DashboardController : Controller
    {

        public DashboardController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
