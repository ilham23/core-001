using Microsoft.AspNetCore.Mvc;

namespace Mi.Web.Controllers
{
    public class ArticleController : Controller
    {
        public ArticleController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
