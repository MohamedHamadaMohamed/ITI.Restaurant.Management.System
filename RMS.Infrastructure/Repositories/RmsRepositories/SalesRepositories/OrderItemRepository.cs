using RMS.Domain.IRepositories.IRmsRepositories.ISalesRepositories;
using RMS.Domain.Models.Sales;
using RMS.Infrastructure.Data.Context;

namespace RMS.Infrastructure.Repositories.RmsRepositories.SalesRepositories
{
    public class OrderItemRepository : Repository<OrderItem, int>, IOrderItemRepository
    {
        public OrderItemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
