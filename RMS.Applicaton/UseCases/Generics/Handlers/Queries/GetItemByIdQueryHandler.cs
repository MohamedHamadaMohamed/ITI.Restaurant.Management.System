using Mapster;
using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models;

namespace RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries
{
    public class GetItemByIdQueryHandler<TEntity, TKey, TEntityDto> : IRequestHandler<GetItemByIdQuery<TEntity, TKey, TEntityDto>, TEntityDto> where TEntity : BaseEntity<TKey>
    {
        private readonly IRepository<TEntity, TKey> _Repository;
        private readonly IUnitOfWork _unitOfWork;
        public GetItemByIdQueryHandler(IUnitOfWork unitOfWork)
        {

            this._unitOfWork = unitOfWork;
            _Repository = _unitOfWork.GetRepository<TEntity, TKey>();

        }

        public Task<TEntityDto> Handle(GetItemByIdQuery<TEntity, TKey, TEntityDto> request, CancellationToken cancellationToken)
        {
            var entity = _Repository.GetById(request.Id);
            var entityDto = entity.Adapt<TEntityDto>();
            return Task.FromResult(entityDto);
        }
    }
}
