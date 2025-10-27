using MediatR;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.AdminCommands;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Commands.AdminCommandHandlers
{
    public class AdminUpdateOrderCommandHandler : UpdateOrderCommandHandler<AdminOrderDto>, IRequestHandler<AdminUpdateOrderCommand,bool>
    {
        public AdminUpdateOrderCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Handle(AdminUpdateOrderCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
