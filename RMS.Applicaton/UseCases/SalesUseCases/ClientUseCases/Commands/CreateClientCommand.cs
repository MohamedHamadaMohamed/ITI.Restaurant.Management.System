using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.ClientDtos;
using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;
using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands
{
    public class CreateClientCommand<TEntityDto> : CreateCommand<Client,int, TEntityDto, ClientCreatedDto>
    {
    }
}
