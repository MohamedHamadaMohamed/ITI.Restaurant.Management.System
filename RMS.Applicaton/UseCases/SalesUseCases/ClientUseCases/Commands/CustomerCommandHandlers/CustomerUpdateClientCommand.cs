using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands.CustomerCommandHandlers
{
    public class CustomerUpdateClientCommand : UpdateClientCommand<CustomerClientDto>
    {
        public CustomerUpdateClientCommand(CustomerClientDto entityDto) : base(entityDto)
        {
        }
    }
}
