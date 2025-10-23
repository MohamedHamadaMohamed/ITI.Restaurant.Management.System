using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Commands;

namespace RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands
{
    public class CreateCommandHandler<TEntity, TKey, TRepository, TEntityDto, TEntityCreatedDto> : IRequestHandler<CreateCommand<TEntity, TKey, TRepository, TEntityDto, TEntityCreatedDto>, TEntityCreatedDto>
    {
        public Task<TEntityCreatedDto> Handle(CreateCommand<TEntity, TKey, TRepository, TEntityDto, TEntityCreatedDto> request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
