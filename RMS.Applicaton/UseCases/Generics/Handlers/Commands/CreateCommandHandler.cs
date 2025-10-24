using Mapster;
using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models;

namespace RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands
{
    public class CreateCommandHandler<TEntity, TKey, TEntityDto, TEntityCreatedDto> : IRequestHandler<CreateCommand<TEntity, TKey, TEntityDto, TEntityCreatedDto>, TEntityCreatedDto> where TEntity : BaseEntity<TKey>
    {
        private readonly IRepository<TEntity, TKey> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<TEntity, TKey>();
        }

        public Task<TEntityCreatedDto> Handle(CreateCommand<TEntity, TKey, TEntityDto, TEntityCreatedDto> request, CancellationToken cancellationToken)
        {
            
            var entity = request.entityDto.Adapt<TEntity>();
            var newEntity = _repository.Create(entity).Adapt<TEntityCreatedDto>();
            
            _unitOfWork.Commit();
            return Task.FromResult(newEntity);
        }
    }
}
