using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Handlers.Queries
{
    public class GetAllMenuItemsQueryHandler<TEntityDto> : GetAllQueryHandler<MenuItem, int, TEntityDto>, IRequestHandler<GetAllQuery<MenuItem, int, TEntityDto>, ICollection<TEntityDto>>
    {
        public GetAllMenuItemsQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
