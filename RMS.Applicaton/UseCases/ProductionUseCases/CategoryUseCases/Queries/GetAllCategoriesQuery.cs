using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries
{
    public class GetAllCategoriesQuery<TEntity> : GetAllQuery<Category, int, TEntity>
    {
    }
}
