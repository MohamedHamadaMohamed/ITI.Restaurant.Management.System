using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries
{
    public class GetOrderByIdQuery<TEntityDto> : GetItemByIdQuery<Client, int, TEntityDto>
    {
        public GetOrderByIdQuery(int id) : base(id)
        {
        }
    }
}
