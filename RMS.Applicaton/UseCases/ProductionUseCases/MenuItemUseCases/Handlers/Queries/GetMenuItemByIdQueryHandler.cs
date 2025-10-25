using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Handlers.Queries
{
    public class GetMenuItemByIdQueryHandler<TEntityDto> : GetItemByIdQueryHandler<MenuItem, int, TEntityDto>, IRequestHandler<GetItemByIdQuery<MenuItem, int, TEntityDto>, TEntityDto>
    {
        public GetMenuItemByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
