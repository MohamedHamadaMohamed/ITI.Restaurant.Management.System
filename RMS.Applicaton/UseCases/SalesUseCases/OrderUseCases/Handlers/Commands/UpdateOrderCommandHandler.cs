using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Commands
{
    public class UpdateOrderCommandHandler<TEntityDto> : UpdateCommandHandler<Order, int, TEntityDto>, IRequestHandler<UpdateOrderCommand<TEntityDto>, bool>
    {
        public UpdateOrderCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Handle(UpdateOrderCommand<TEntityDto> request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
