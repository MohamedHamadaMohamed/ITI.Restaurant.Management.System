using MediatR;

namespace RMS.Applicaton.Layer.UseCases.Generics.Commands
{
    public class UpdateCommand<TEntity, TKey, TEntityDto> : IRequest<bool>
    {
        public UpdateCommand(TEntityDto entityDto)
        {
            this.entityDto = entityDto;
        }

        public TEntityDto entityDto { get; set; }
    }
}
