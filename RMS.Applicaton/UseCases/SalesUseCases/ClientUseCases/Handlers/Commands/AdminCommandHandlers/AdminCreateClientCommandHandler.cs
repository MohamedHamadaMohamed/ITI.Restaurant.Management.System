using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.ClientDtos;
using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands.AdminCommands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.AdminCommands;
using RMS.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Commands.AdminCommandHandlers
{
    public class AdminCreateClientCommandHandler : CreateClientCommandHandler<AdminClientDto>, IRequestHandler<AdminCreateClientCommand,ClientCreatedDto>
    {
        public AdminCreateClientCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ClientCreatedDto> Handle(AdminCreateClientCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
