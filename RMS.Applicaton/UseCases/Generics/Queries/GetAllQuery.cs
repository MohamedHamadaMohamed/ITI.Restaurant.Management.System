using MediatR;

namespace RMS.Applicaton.Layer.UseCases.Generics.Queries
{
    public class GetAllQuery<TEntity,TKey,TRepository,TEntityDto> : IRequest<ICollection<TEntityDto>>
    {
    }
}
