using Microsoft.AspNetCore.Mvc;

namespace CoreIdentity.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
