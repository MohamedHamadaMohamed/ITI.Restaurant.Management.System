using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemCases.Queries;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Queries.AdminQueries
{
    public class AdminGetMenuItemByIdQuery : GetMenuItemByIdQuery<AdminMenuItemDto>
    {
        public AdminGetMenuItemByIdQuery(int id) : base(id)
        {
        }
    }
}
