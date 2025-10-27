using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands.CustomerCommands

{
    public class CustomerUpdateClientCommand : UpdateClientCommand<CustomerClientDto>
    {
        public CustomerUpdateClientCommand(CustomerClientDto entityDto) : base(entityDto)
        {
        }
    }
}
