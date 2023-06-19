namespace OnlineShopMVC.Models
{
    public class Review
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; } // Reference to the associated product
        public int UserId { get; set; }
        public User User { get; set; } // Reference to the associated user
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
