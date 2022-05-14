using CoreIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreIdentity.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {

        private readonly UserManager<MyUser> _userManager;

        public RegisterController(UserManager<MyUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {
                MyUser w = new MyUser()
                {
                    Email = p.Mail,
                    UserName = p.UserName,
                    ImageUrl = p.ImageUrl
                };

                if (p.Password == p.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(w, p.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
            }
            return View(p);
        }
    }
}