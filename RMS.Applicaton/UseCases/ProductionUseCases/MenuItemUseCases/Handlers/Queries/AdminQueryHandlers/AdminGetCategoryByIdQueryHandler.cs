using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Queries.AdminQueries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Handlers.Queries.AdminQueryHandlers
{
    public class AdminGetMenuItemByIdQueryHandler : GetMenuItemByIdQueryHandler<AdminMenuItemDto>, IRequestHandler<AdminGetMenuItemByIdQuery, AdminMenuItemDto>
    {
        public AdminGetMenuItemByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<AdminMenuItemDto> Handle(AdminGetMenuItemByIdQuery request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
