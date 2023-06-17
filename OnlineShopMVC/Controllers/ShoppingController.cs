using Microsoft.AspNetCore.Mvc;

namespace OnlineShopMVC.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View("register");
        }
    }

}
