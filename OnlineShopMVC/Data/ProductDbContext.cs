using Microsoft.EntityFrameworkCore;
using OnlineShopMVC.Models;

namespace OnlineShopMVC.Data
{
	public class ProductDbContext : DbContext
	{
		public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
		{

		}
		public DbSet<Product> Products { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Cart> CartUsers { get; set; }
		public DbSet<Category> Categorys { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Shipping> Shippings { get; set; }
	}
}
