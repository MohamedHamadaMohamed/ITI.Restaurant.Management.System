using MediatR;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Queries.CustomerQueryHandlers
{
    public class CustomerGetClientByIdQueryHandler : GetClientByIdQueryHandler<CustomerClientDto>, IRequestHandler<GetClientByIdQuery<CustomerClientDto>, CustomerClientDto>
    {
        public CustomerGetClientByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<CustomerClientDto> Handle(GetClientByIdQuery<CustomerClientDto> request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
