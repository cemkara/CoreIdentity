using CoreIdentity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreIdentity.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminArticleController : Controller
    {
        public IActionResult Index()
        {
            using (Context c = new Context())
            {
                var list = c.AdminArticles.ToList();
                return View(list);
            }
        }
    }
}
