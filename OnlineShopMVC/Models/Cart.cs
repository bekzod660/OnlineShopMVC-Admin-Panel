namespace OnlineShopMVC.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        // Other cart item properties

        public Product? Product { get; set; }
    }
}
