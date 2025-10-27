using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Commands
{
    public class DeleteOrderCommandHandler : DeleteCommandHandler<Order, int>, IRequestHandler<DeleteOrderCommand, bool>
    {
        public DeleteOrderCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);

        }
    }
}
