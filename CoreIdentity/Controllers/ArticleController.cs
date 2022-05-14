using CoreIdentity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreIdentity.Controllers
{
    [Authorize(Roles = "User")]
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            using (Context c = new Context())
            {
                var list = c.Articles.ToList();
                return View(list);
            }
        }
    }
}
