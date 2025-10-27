using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Queries
{
    public class GetOrderByIdQueryHandler<TEntityDto> : GetItemByIdQueryHandler<Order, int, TEntityDto>, IRequestHandler<GetOrderByIdQuery< TEntityDto>, TEntityDto>
    {
        public GetOrderByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<TEntityDto> Handle(GetOrderByIdQuery<TEntityDto> request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
