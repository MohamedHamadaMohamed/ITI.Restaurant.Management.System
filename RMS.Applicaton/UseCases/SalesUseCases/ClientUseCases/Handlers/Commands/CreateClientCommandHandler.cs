using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.ClientDtos;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Commands
{
    public class CreateClientCommandHandler<TEntityDto> : CreateCommandHandler<Client, int, TEntityDto, ClientCreatedDto>, IRequestHandler<CreateClientCommand<TEntityDto>, ClientCreatedDto>
    {
        public CreateClientCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ClientCreatedDto> Handle(CreateClientCommand<TEntityDto> request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
