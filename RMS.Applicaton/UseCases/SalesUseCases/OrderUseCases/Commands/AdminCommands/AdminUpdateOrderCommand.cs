using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands.AdminCommands
{
    public class AdminUpdateOrderCommand : UpdateOrderCommand<AdminOrderDto>
    {
        public AdminUpdateOrderCommand(AdminOrderDto entityDto) : base(entityDto)
        {
        }
    }
}
