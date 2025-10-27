using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.CustomerCommands

{
    public class CustomerUpdateOrderCommand : UpdateOrderCommand<CustomerOrderDto>
    {
        public CustomerUpdateOrderCommand(CustomerOrderDto entityDto) : base(entityDto)
        {
        }
    }
}
