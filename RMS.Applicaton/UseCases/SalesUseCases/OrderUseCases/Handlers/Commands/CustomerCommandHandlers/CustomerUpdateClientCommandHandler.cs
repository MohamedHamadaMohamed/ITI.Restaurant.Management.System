using MediatR;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.CustomerCommands;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Commands.CustomerCommandHandlers
{
    public class CustomerUpdateOrderCommandHandler : UpdateOrderCommandHandler<CustomerOrderDto>, IRequestHandler<CustomerUpdateOrderCommand,bool>
    {
        public CustomerUpdateOrderCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<bool> Handle(CustomerUpdateOrderCommand request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
