using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShopMVC.Controllers
{
	// [Authorize]
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View("Index");
		}
		[AllowAnonymous]
		//[Route("/admin")]
		public IActionResult SignIn()
		{
			return View();
		}

		public IActionResult VendorList()
		{
			return View("vendorList");
		}
	}
}
