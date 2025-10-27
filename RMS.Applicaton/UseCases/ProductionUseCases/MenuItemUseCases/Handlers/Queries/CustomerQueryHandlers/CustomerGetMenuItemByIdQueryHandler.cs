using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Queries.CustomerQueries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Handlers.Queries.CustomerQueryHandlers
{
    public class CustomerGetMenuItemByIdQueryHandler : GetMenuItemByIdQueryHandler<CustomerMenuItemDto>, IRequestHandler<CustomerGetMenuItemByIdQuery, CustomerMenuItemDto>
    {
        public CustomerGetMenuItemByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<CustomerMenuItemDto> Handle(CustomerGetMenuItemByIdQuery request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
