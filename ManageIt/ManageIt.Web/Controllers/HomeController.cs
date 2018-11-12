using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ManageIt.Infrastructure.Services.Interfaces;
using System.Threading.Tasks;
using ManageIt.Web.Models.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using ManageIt.Infrastructure.Models.DTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
