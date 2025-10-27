using MediatR;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands.CustomerCommands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.CustomerCommands;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Commands.CustomerCommandHandlers
{
    public class CustomerUpdateClientCommandHandler : UpdateClientCommandHandler<CustomerClientDto>, IRequestHandler<CustomerUpdateClientCommand,bool>
    {
        public CustomerUpdateClientCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<bool> Handle(CustomerUpdateClientCommand request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
