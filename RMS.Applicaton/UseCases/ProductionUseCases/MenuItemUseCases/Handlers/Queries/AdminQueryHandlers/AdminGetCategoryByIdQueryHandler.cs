using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemCases.Queries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Handlers.Queries.AdminQueryHandlers
{
    public class AdminGetMenuItemByIdQueryHandler : GetMenuItemByIdQueryHandler<AdminMenuItemDto>, IRequestHandler<GetMenuItemByIdQuery<AdminMenuItemDto>, AdminMenuItemDto>
    {
        public AdminGetMenuItemByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<AdminMenuItemDto> Handle(GetMenuItemByIdQuery<AdminMenuItemDto> request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
