using MediatR;

namespace RMS.Applicaton.Layer.UseCases.Generics.Queries
{
    public class GetAllQuery<TEntity,TKey,TEntityDto> : IRequest<ICollection<TEntityDto>>
    {
    }
}
