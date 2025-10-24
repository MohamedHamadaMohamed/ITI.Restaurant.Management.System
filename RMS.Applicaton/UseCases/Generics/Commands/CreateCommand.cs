using MediatR;

namespace RMS.Applicaton.Layer.UseCases.Generics.Commands
{
    public class CreateCommand<TEntity, TKey, TEntityDto,TEntityCreatedDto> : IRequest<TEntityCreatedDto>
    {
        public TEntityCreatedDto entityDto { get; set; }
    }
}
