using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemCases.Queries
{
    public class GetMenuItemByIdQuery<TEntityDto> : GetItemByIdQuery<MenuItem, int, TEntityDto>
    {
        public GetMenuItemByIdQuery(int id) : base(id)
        {
        }
    }
}
