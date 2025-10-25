using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Handlers.Commands
{
    public class UpdateMenuItemCommandHandler : UpdateCommandHandler<MenuItem, int, AdminMenuItemDto>, IRequestHandler<UpdateMenuItemCommand, bool>
    {
        public UpdateMenuItemCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Handle(UpdateMenuItemCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
