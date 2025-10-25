using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Queries
{
    public class GetAllMenuItemsQuery<TEntity> : GetAllQuery<MenuItem, int, TEntity>
    {
    }
}
