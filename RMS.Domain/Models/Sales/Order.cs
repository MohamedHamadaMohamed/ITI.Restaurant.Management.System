using RMS.Domain.Constants;

namespace RMS.Domain.Models.Sales
{
    public class Order : BaseEntity<int>
    {
        public OrderStatus status { get; set; } = OrderStatus.Pending;
        public Payment Payment { get; set; } = Payment.Cash;
        public int CLientId { get; set; }
        public Client Client { get; set; } = null!;
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
