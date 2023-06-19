namespace OnlineShopMVC.Models
{
	public class Product
	{
		public Guid ProductId { get; set; }
		public string ProductName { get; set; }
		public string Slug { get; set; }
		public string SortDescription { get; set; }
		public string[] Colors { get; set; }
		public string[] Sizes { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public string FullDetail { get; set; }
		public string ProductTags { get; set; }
		public string[] ImageData { get; set; }

		public string[] Categories { get; set; }
		//public List<Review>? Reviews { get; set; }
	}
}
