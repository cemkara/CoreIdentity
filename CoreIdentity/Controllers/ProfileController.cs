using CoreIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreIdentity.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<MyUser> _userManager;

        public ProfileController(UserManager<MyUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var myUser = await _userManager.FindByNameAsync(User.Identity.Name);

            return View(myUser);
        }
    }
}
