using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries
{
    public class GetAllOrdersQuery<TEntity> : GetAllQuery<Client, int, TEntity>
    {
    }
}
