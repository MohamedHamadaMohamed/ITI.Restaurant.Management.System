using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries;
using RMS.Domain.IRepositories;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Queries.AdminQueryHandlers
{
    public class CustomerGetClientByIdQueryHandler : GetClientByIdQueryHandler<AdminClientDto>, IRequestHandler<GetOrderByIdQuery<AdminClientDto>, AdminClientDto>
    {
        public CustomerGetClientByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<AdminClientDto> Handle(GetOrderByIdQuery<AdminClientDto> request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
