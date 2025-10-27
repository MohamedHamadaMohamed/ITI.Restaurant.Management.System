using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Handlers.Queries
{
    public class GetAllMenuItemsQueryHandler<TEntityDto> : GetAllQueryHandler<MenuItem, int, TEntityDto>, IRequestHandler<GetAllMenuItemsQuery<TEntityDto>, ICollection<TEntityDto>>
    {
        public GetAllMenuItemsQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ICollection<TEntityDto>> Handle(GetAllMenuItemsQuery<TEntityDto> request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
