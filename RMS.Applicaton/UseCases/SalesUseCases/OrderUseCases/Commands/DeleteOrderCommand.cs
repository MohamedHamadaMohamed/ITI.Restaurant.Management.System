using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Production;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands
{
    public class DeleteOrderCommand : DeleteCommand<Order, int>
    {
        public DeleteOrderCommand(int id) : base(id)
        {
        }
    }
}
