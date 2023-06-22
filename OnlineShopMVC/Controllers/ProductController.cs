using Microsoft.AspNetCore.Mvc;
using OnlineShopMVC.Data;
using OnlineShopMVC.Filters;
using OnlineShopMVC.Models;
using OnlineShopMVC.Models.ViewModels;

namespace OnlineShopMVC.Controllers
{
    public class ProductController : Controller
    {
        public readonly ProductDbContext _db;
        public readonly IWebHostEnvironment _root;

        public ProductController(ProductDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductAdd()
        {
            return View();
        }
        [HttpPost]
        [ExtensionValidation(new[] { "jpeg" })]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductCreate(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                List<string> imagePath = new List<string>();
                for (int i = 0; i < product.ImageData.Length; i++)
                {
                    var fileName = new Guid() + Path.GetFileName(product.ImageData[i].FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\imagesProduct", fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await product.ImageData[i].CopyToAsync(fileStream);
                    }
                    imagePath.Add(fileName);
                }
                Product _product = new Product
                {
                    ProductId = new Guid(),
                    ProductName = product.ProductName,
                    Sizes = product.Sizes.ToArray(),
                    Colors = product.Colors.ToArray(),
                    Price = product.Price,
                    ProductTags = product.ProductTags,
                    Quantity = product.Quantity,
                    Categories = product.Categories,
                    FullDetail = product.FullDetail,
                    ImageData = imagePath.ToArray()
                };
                _db.Products.Add(_product);
                await _db.SaveChangesAsync();
            }
            return View("ProductAdd");
        }
        public IActionResult ProductList()
        {
            IEnumerable<Product> products = _db.Products;
            return View(products);
        }
        public IActionResult ProductGrid()
        {
            IEnumerable<Product> products = _db.Products;
            return View(products);
        }

        public IActionResult ProductLeftSideBar(Guid id)
        {
            Product product = _db.Products.FirstOrDefault(x => x.ProductId == id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([Bind("ProductId,ProductName, Categories, Slug,SortDescription,Colors,Sizes, Price, Quantity, FullDetail,ProductTags, ImageData")] ProductViewModel product)
        {
            if (product.ImageData != null && product.ImageData.Length > 0)
            {
                List<string> imagePath = new List<string>();
                for (int i = 0; i < product.ImageData.Length; i++)
                {
                    var fileName = new Guid() + Path.GetFileName(product.ImageData[i].FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\imagesProduct", fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await product.ImageData[i].CopyToAsync(fileStream);
                    }
                    imagePath.Add(fileName);
                }

                Product _product = _db.Products.First(x => x.ProductId == product.ProductId);
                _product.ProductName = product.ProductName;
                _product.ProductTags = product.ProductTags;
                _product.Categories = product.Categories;
                _product.Colors = product.Colors.ToArray();
                _product.Price = product.Price;
                _product.Quantity = product.Quantity;
                _product.FullDetail = product.FullDetail;
                _product.ImageData = imagePath.ToArray();
                _db.Products.Update(_product);
                _db.SaveChanges();
                return RedirectToAction("ProductList");
            }
            return View("ProductAdd");
        }
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _db.Products.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ProductViewModel model = new ProductViewModel()
            {
                ProductId = employee.ProductId,
                ProductName = employee.ProductName,
                FullDetail = employee.FullDetail,
                Sizes = employee.Sizes.ToArray(),
                Price = employee.Price,
                Quantity = employee.Quantity

            };
            return View(employee);
        }
    }
}
