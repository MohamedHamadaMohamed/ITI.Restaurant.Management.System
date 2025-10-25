using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Commands
{
    public class DeleteMenuItemCommandHandler : DeleteCommandHandler<MenuItem, int>, IRequestHandler<DeleteMenuItemCommand, bool>
    {
        public DeleteMenuItemCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Handle(DeleteMenuItemCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);

        }
    }
}
