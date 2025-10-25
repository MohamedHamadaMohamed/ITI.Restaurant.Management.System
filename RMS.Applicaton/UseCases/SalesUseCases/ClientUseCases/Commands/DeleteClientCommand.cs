using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Production;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands
{
    public class DeleteClientCommand : DeleteCommand<Client, int>
    {
        public DeleteClientCommand(int id) : base(id)
        {
        }
    }
}
