using Microsoft.AspNetCore.Mvc;
using OnlineShopMVC.Models;

namespace OnlineShopMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm] UserViewModel user)
        {
            return View();
        }
        [HttpPost]
        [ActionName("Register")]
        public IActionResult Register([FromForm] User person)
        {
            return Ok();
        }
    }
}
