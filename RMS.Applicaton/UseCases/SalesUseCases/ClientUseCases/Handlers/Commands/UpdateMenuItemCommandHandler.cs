using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;
using RMS.Domain.Models.Sales;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Commands
{
    public class UpdateClientCommandHandler<TEntityDto> : UpdateCommandHandler<Client, int, TEntityDto>, IRequestHandler<UpdateClientCommand<TEntityDto>, bool>
    {
        public UpdateClientCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Handle(UpdateClientCommand<TEntityDto> request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
