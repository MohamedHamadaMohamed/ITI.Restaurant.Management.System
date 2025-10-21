using RMS.Domain.IRepositories.IRmsRepositories.ISalesRepositories;
using RMS.Domain.Models.Sales;
using RMS.Infrastructure.Data.Context;

namespace RMS.Infrastructure.Repositories.RmsRepositories.SalesRepositories
{
    public class OrderRepository : Repository<Order, int>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
