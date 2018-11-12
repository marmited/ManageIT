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

namespace ManageIt.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            UserDto user = new UserDto();//.Authenticate(model.Email, model.Password);
            if (user == null)
            {
                ModelState.AddModelError("InvalidCredentials", "Could not valid your credentials");
                return View(model);
            }
            return await SignInUser(user);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            UserDto user = await _userService.RegisterAsync(model.Email, model.FirstName, model.LastName, model.Password);

            return await SignInUser(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private async Task<IActionResult> SignInUser(UserDto user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Email),
                new Claim(ClaimTypes.Name, user.FullName),
                new Claim(ClaimTypes.Email, user.Email),
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(principal);

            return RedirectToAction("Dashboard", "Home");
        }
    }
}
