namespace OnlineShopMVC.DTOs
{
    public class CartAddDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
    }
}
