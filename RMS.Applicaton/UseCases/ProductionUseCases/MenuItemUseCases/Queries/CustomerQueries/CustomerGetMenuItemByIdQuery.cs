using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Queries.CustomerQueries
{
    public class CustomerGetMenuItemByIdQuery : GetClientByIdQuery<CustomerMenuItemDto>
    {
        public CustomerGetMenuItemByIdQuery(int id) : base(id)
        {
        }
    }
}
