namespace Ecommerce.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime OrderTime { get; set; } = DateTime.UtcNow;
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Pending";
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
        public string ShippingAddress { get; set; } = null!;
    }
}
