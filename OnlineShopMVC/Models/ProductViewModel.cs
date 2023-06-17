namespace OnlineShopMVC.Models
{
	public class ProductViewModel
	{
		public Guid ProductId { get; set; }
		public string ProductName { get; set; }
		public string Categories { get; set; }
		public string Slug { get; set; }
		public string SortDescription { get; set; }
		public string[] Colors { get; set; }
		public string[] Sizes { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public string FullDetail { get; set; }
		public string ProductTags { get; set; }
		public IFormFile[] ImageData { get; set; }
	}
}
