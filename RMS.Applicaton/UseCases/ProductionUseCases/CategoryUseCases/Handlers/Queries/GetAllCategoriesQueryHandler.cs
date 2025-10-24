using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Handlers.Queries
{
    public class GetAllCategoriesQueryHandler<TEntityDto> : GetAllQueryHandler<Category, int, TEntityDto>, IRequestHandler<GetAllQuery<Category, int, TEntityDto>, ICollection<TEntityDto>>
    {
        public GetAllCategoriesQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
