using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.OrderDtos;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.CustomerCommands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.CustomerCommands;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Commands.CustomerCommandHandlers
{
    public class CustomerCreateOrderCommandHandler : CreateOrderCommandHandler<CustomerOrderDto>, IRequestHandler<CustomerCreateOrderCommand,OrderCreatedDto>
    {
        public CustomerCreateOrderCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<OrderCreatedDto> Handle(CustomerCreateOrderCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
