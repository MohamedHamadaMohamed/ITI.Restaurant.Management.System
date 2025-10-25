using RMS.Domain.Constants;

namespace RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.OrderDtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public OrderStatus status { get; set; } = OrderStatus.Pending;
        public Payment Payment { get; set; } = Payment.Cash;
        public int CLientId { get; set; }
    }
}
