using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries
{
    public class GetClientByIdQuery<TEntityDto> : GetItemByIdQuery<Client, int, TEntityDto>
    {
        public GetClientByIdQuery(int id) : base(id)
        {
        }
    }
}
