using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyECommerce.WebUI.Identity;
using MyECommerce.WebUI.Models;

namespace MyECommerce.WebUI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<ECommerceUser> userManager;
        private SignInManager<ECommerceUser> signInManager;
        public AccountController(UserManager<ECommerceUser> _userManager, SignInManager<ECommerceUser> _signInManager) {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public IActionResult Index(string returnUrl)
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string returnUrl) {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model ,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var _user = await userManager.FindByEmailAsync(model.Email);
                if (_user != null)
                {
                    await signInManager.SignOutAsync();
                    var result = await signInManager.PasswordSignInAsync(_user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                }
            }
            ModelState.AddModelError(nameof(model.Email), "Wrong E-mail or Password");
            return View(model);
        }

        public async Task<IActionResult> Logout() {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}