using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries;
using RMS.Domain.IRepositories;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Queries.AdminQueryHandlers
{
    public class CustomerGetClientByIdQueryHandler : GetClientByIdQueryHandler<AdminClientDto>, IRequestHandler<GetClientByIdQuery<AdminClientDto>, AdminClientDto>
    {
        public CustomerGetClientByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<AdminClientDto> Handle(GetClientByIdQuery<AdminClientDto> request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
