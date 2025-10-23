using MediatR;

namespace RMS.Applicaton.Layer.UseCases.Generics.Commands
{
    public class CreateCommand<TEntity, TKey, TRepository, TEntityDto,TEntityCreatedDto> : IRequest<TEntityCreatedDto>
    {
    }
}
