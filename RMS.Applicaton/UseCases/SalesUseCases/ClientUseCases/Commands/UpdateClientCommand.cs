using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands
{
    public class UpdateClientCommand<TEntityDto> : UpdateCommand<Client, int, TEntityDto>
    {
        public UpdateClientCommand(TEntityDto entityDto) : base(entityDto)
        {
        }
    }
}
