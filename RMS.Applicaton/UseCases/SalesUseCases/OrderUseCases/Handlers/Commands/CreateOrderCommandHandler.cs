using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.OrderDtos;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Commands
{
    public class CreateOrderCommandHandler<TEntityDto> : CreateCommandHandler<Order, int, TEntityDto, OrderCreatedDto>, IRequestHandler<CreateOrderCommand<TEntityDto>, OrderCreatedDto>
    {
        public CreateOrderCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<OrderCreatedDto> Handle(CreateOrderCommand<TEntityDto> request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
