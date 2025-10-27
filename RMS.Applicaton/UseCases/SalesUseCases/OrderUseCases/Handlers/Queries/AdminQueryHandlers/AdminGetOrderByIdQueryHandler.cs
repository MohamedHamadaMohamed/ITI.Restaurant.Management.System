using MediatR;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Queries.AdminQueryHandlers
{
    public class CustomerGetOrderByIdQueryHandler : GetOrderByIdQueryHandler<AdminOrderDto>, IRequestHandler<GetOrderByIdQuery<AdminOrderDto>, AdminOrderDto>
    {
        public CustomerGetOrderByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<AdminOrderDto> Handle(GetOrderByIdQuery<AdminOrderDto> request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
