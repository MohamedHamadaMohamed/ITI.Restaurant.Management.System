using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Queries.CustomerQueries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;



namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Handlers.Queries.CustomerQueryHandlers
{
    public class CustomerGetAllMenuItemsQueryHandler : GetAllMenuItemsQueryHandler<CustomerMenuItemDto>, IRequestHandler<CustomerGetAllMenuItemsQuery, ICollection<CustomerMenuItemDto>>
    {
        public CustomerGetAllMenuItemsQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ICollection<CustomerMenuItemDto>> Handle(CustomerGetAllMenuItemsQuery request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
