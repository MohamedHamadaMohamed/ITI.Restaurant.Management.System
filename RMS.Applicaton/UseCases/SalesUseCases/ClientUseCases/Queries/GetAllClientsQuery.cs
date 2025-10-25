using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries
{
    public class GetAllClientsQuery<TEntity> : GetAllQuery<Client, int, TEntity>
    {
    }
}
