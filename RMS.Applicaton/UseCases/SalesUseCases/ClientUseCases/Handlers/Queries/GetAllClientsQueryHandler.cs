using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Queries
{
    public class GetAllClientsQueryHandler<TEntityDto> : GetAllQueryHandler<Client, int, TEntityDto>, IRequestHandler<GetAllOrdersQuery<TEntityDto>, ICollection<TEntityDto>>
    {
        public GetAllClientsQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ICollection<TEntityDto>> Handle(GetAllOrdersQuery<TEntityDto> request, CancellationToken cancellationToken)
        {
               return await base.Handle(request, cancellationToken);
        }
    }
}
