using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemCases.Queries;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Queries.CustomerQueries
{
    public class CustomerGetMenuItemByIdQuery : GetMenuItemByIdQuery<CustomerMenuItemDto>
    {
        public CustomerGetMenuItemByIdQuery(int id) : base(id)
        {
        }
    }
}
