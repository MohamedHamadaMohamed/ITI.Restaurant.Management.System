using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.MenuItemDtos;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Commands
{
    public class CreateMenuItemCommandHandler : CreateCommandHandler<MenuItem, int, AdminMenuItemDto, MenuItemCreatedDto>, IRequestHandler<CreateMenuItemCommand,MenuItemCreatedDto>
    {
        public CreateMenuItemCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<MenuItemCreatedDto> Handle(CreateMenuItemCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
