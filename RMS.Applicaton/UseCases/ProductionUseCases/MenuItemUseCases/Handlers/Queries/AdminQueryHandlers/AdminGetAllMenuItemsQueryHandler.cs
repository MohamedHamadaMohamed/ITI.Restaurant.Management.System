using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Queries.AdminQueries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Handlers.Queries.AdminQueryHandlers
{
    public class AdminGetAllMenuItemsQueryHandler : GetAllMenuItemsQueryHandler<AdminMenuItemDto>, IRequestHandler<AdminGetAllMenuItemsQuery, ICollection<AdminMenuItemDto>>
    {
        public AdminGetAllMenuItemsQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ICollection<AdminMenuItemDto>> Handle(AdminGetAllMenuItemsQuery request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
