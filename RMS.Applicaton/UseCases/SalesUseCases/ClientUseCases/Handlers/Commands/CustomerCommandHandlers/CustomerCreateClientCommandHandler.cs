using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.ClientDtos;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands.CustomerCommands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.CustomerCommands;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Commands.CustomerCommandHandlers
{
    public class CustomerCreateClientCommandHandler : CreateClientCommandHandler<CustomerClientDto>, IRequestHandler<CustomerCreateClientCommand,ClientCreatedDto>
    {
        public CustomerCreateClientCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ClientCreatedDto> Handle(CustomerCreateClientCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
