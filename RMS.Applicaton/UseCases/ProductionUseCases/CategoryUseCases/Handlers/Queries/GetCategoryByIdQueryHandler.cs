using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Handlers.Queries
{
    public class GetCategoryByIdQueryHandler<TEntityDto> : GetItemByIdQueryHandler<Category, int, TEntityDto>, IRequestHandler<GetItemByIdQuery<Category, int, TEntityDto>, TEntityDto>
    {
        public GetCategoryByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
