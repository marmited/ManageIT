using Microsoft.AspNetCore.Mvc;

namespace ManageIt.Web.Controllers
{
    public class ProfileController : Controller
    {

        public ProfileController()
        {
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}
