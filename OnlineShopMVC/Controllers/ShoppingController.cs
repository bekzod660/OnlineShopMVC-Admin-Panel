using Microsoft.AspNetCore.Mvc;
using OnlineShopMVC.Data;
using OnlineShopMVC.Models;

namespace OnlineShopMVC.Controllers
{

    public class ShoppingController : Controller
    {
        private readonly ProductDbContext _db;

        public ShoppingController(ProductDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> res = _db.Products;
            return View(res);
        }

    }

}
