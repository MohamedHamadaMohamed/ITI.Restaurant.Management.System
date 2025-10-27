using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.OrderDtos;
using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Commands
{
    public class CreateOrderCommand<TEntityDto> : CreateCommand<Client,int, TEntityDto, OrderCreatedDto>
    {
    }
}
