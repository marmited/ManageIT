using Microsoft.AspNetCore.Mvc;

namespace ManageIt.Web.Controllers
{
    public class MessageController : Controller
    {

        public MessageController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
