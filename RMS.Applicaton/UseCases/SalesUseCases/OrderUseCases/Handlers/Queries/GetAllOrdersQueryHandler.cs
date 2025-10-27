using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Queries
{
    public class GetAllOrdersQueryHandler<TEntityDto> : GetAllQueryHandler<Order, int, TEntityDto>, IRequestHandler<GetAllOrdersQuery<TEntityDto>, ICollection<TEntityDto>>
    {
        public GetAllOrdersQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ICollection<TEntityDto>> Handle(GetAllOrdersQuery<TEntityDto> request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
