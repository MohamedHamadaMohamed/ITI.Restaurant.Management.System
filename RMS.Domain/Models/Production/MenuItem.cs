using RMS.Domain.Models.Sales;
using RMS.Domain.Shared;

namespace RMS.Domain.Models.Production
{
    public class MenuItem : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Money Price { get; set; } = null!;
        public double Discount { get; set; } = 0;
        public bool IsAvailable { get; set; } = true;
        public int DailyOrderCount { get; set; } = 0;
        public int PreparationTimeMinutes { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
