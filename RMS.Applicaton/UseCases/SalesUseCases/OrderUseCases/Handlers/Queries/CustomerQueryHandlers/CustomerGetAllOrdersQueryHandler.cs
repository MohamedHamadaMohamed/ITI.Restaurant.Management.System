using MediatR;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries.CustomerQueries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;



namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Queries.CustomerQueryHandlers
{
    public class CustomerGetAllOrdersQueryHandler : GetAllOrdersQueryHandler<CustomerOrderDto>, IRequestHandler<CustomerGetAllOrdersQuery, ICollection<CustomerOrderDto>>
    {
        public CustomerGetAllOrdersQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ICollection<CustomerOrderDto>> Handle(CustomerGetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
