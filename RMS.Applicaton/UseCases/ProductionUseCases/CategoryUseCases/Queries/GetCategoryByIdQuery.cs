using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries
{
    public class GetCategoryByIdQuery<TEntityDto> : GetItemByIdQuery<Category, int, TEntityDto>
    {
        public GetCategoryByIdQuery(int id) : base(id)
        {
        }
    }
}
