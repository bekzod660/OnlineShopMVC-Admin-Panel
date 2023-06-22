namespace OnlineShopMVC.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public User UserId { get; set; }
        public int Quantity { get; set; }
        public Product? Product { get; set; }
    }
}
