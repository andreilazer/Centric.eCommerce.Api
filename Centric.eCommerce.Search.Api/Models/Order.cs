namespace Centric.eCommerce.Search.Api.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
        public List<OrderItem> Items { get; set; }
        
    }
}
