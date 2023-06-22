using Microsoft.AspNetCore.Mvc;
using OnlineShopMVC.Data;
using OnlineShopMVC.DTOs;
using OnlineShopMVC.Models;

namespace OnlineShopMVC.Controllers
{
    public class OrderController : Controller
    {
        public readonly ProductDbContext _db;
        public OrderController(ProductDbContext db)
        {
            _db = db;
        }

        public IActionResult ViewCartAdd(CartAddDTO product)
        {
            Cart cart = new Cart()
            {
                Id = new Guid(),
                Quantity = product.Quantity,
                Product = _db.Products.FirstOrDefault(x => x.ProductId == product.ProductId)
            };
            _db.Cart.Add(cart);
            return View();
        }
        public IActionResult ViewCart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
