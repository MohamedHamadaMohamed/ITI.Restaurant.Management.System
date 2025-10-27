using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries.CustomerQueries
{
    public class CustomerGetClientByIdQuery : GetOrderByIdQuery<CustomerClientDto>
    {
        public CustomerGetClientByIdQuery(int id) : base(id)
        {
        }
    }
}
