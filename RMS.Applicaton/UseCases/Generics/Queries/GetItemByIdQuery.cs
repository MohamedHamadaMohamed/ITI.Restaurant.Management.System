using MediatR;

namespace RMS.Applicaton.Layer.UseCases.Generics.Queries
{
    public class GetItemByIdQuery<TEntity, TKey, TEntityDto> : IRequest<TEntityDto>
    {
        public TKey Id { get; set; }
        public GetItemByIdQuery(TKey id)
        {
            Id = id;
        }
    }
}
