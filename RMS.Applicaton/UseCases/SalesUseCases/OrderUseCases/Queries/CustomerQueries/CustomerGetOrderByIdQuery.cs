using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries.CustomerQueries
{
    public class CustomerGetOrderByIdQuery : GetOrderByIdQuery<CustomerOrderDto>
    {
        public CustomerGetOrderByIdQuery(int id) : base(id)
        {
        }
    }
}
