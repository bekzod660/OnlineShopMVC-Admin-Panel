using Microsoft.AspNetCore.Mvc;
using OnlineShopMVC.Data;
using OnlineShopMVC.Models;

namespace OnlineShopMVC.Controllers
{

	public class ShoppingController : Controller
	{
		private readonly ProductDbContext _db;
		private readonly LinkGenerator _linkGenerator;


		public ShoppingController(ProductDbContext db, LinkGenerator linkGenerator)
		{
			_db = db;
			_linkGenerator = linkGenerator;
		}

		public IActionResult Index()
		{
			//var url = _linkGenerator.GetPathByPage(HttpContext, page: "/Login");
			IEnumerable<Product> res = _db.Products;
			return View(res);
		}

	}

}
