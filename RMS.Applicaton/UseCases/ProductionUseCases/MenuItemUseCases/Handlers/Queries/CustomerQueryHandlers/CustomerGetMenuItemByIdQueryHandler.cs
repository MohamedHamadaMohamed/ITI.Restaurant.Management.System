using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemCases.Queries;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries.CustomerQueries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Admin.Models;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Handlers.Queries.CustomerQueryHandlers
{
    public class CustomerGetMenuItemByIdQueryHandler : GetMenuItemByIdQueryHandler<CustomerMenuItemDto>, IRequestHandler<GetMenuItemByIdQuery<CustomerMenuItemDto>, CustomerMenuItemDto>
    {
        public CustomerGetMenuItemByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<CustomerMenuItemDto> Handle(GetMenuItemByIdQuery<CustomerMenuItemDto> request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
