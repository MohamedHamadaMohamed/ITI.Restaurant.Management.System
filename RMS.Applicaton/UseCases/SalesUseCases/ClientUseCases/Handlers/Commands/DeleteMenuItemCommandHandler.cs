using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Commands
{
    public class DeleteClientCommandHandler : DeleteCommandHandler<Client, int>, IRequestHandler<DeleteClientCommand, bool>
    {
        public DeleteClientCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);

        }
    }
}
