using Microsoft.AspNetCore.Mvc;

namespace ManageIt.Web.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
