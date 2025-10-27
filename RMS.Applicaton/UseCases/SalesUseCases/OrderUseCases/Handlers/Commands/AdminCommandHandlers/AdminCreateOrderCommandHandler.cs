using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.OrderDtos;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.AdminCommands;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Commands.AdminCommandHandlers
{
    public class AdminCreateOrderCommandHandler : CreateOrderCommandHandler<AdminOrderDto>, IRequestHandler<AdminCreateOrderCommand,OrderCreatedDto>
    {
        public AdminCreateOrderCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<OrderCreatedDto> Handle(AdminCreateOrderCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
