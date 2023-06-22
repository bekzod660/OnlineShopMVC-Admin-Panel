namespace OnlineShopMVC.Models
{
    public class Shipping
    {
        public Guid Id { get; set; }
        public string Carrier { get; set; }
        public string DeliveryOptions { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
