using MediatR;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Queries.CustomerQueryHandlers
{
    public class CustomerGetOrderByIdQueryHandler : GetOrderByIdQueryHandler<CustomerOrderDto>, IRequestHandler<GetOrderByIdQuery<CustomerOrderDto>, CustomerOrderDto>
    {
        public CustomerGetOrderByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<CustomerOrderDto> Handle(GetOrderByIdQuery<CustomerOrderDto> request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
