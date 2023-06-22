namespace OnlineShopMVC.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        // public Guid OrderId { get; set; }
        public Order Order { get; set; } // Reference to the associated order
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; }
    }
}
