using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands.AdminCommands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.AdminCommands;
using RMS.Domain.IRepositories;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Commands.AdminCommandHandlers
{
    public class AdminUpdateOrderCommandHandler : UpdateClientCommandHandler<AdminClientDto>, IRequestHandler<AdminUpdateClientCommand,bool>
    {
        public AdminUpdateOrderCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Handle(AdminUpdateClientCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
