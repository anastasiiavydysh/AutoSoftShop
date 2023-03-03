using Microsoft.AspNetCore.Mvc;

namespace AutoSoftShop.AutoSoftShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
