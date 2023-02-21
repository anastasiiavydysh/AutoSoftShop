using Microsoft.AspNetCore.Mvc;

namespace AutoSoftShop.AutoSoftShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
