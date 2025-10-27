using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands
{
    public class UpdateOrderCommand<TEntityDto> : UpdateCommand<Order, int, TEntityDto>
    {
        public UpdateOrderCommand(TEntityDto entityDto) : base(entityDto)
        {
        }
    }
}
