using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models;

namespace RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries
{
    public class GetAllQueryHandler<TEntity, TKey, TEntityDto> : IRequestHandler<GetAllQuery<TEntity, TKey, TEntityDto>, ICollection<TEntityDto>> where TEntity : BaseEntity<TKey>
    {


        private readonly IRepository<TEntity, TKey> _Repository;
        private readonly IUnitOfWork _unitOfWork;

        public GetAllQueryHandler( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _Repository = _unitOfWork.GetRepository<TEntity, TKey>();
        }
        public async Task<ICollection<TEntityDto>> Handle(GetAllQuery<TEntity, TKey, TEntityDto> request, CancellationToken cancellationToken)
        {
            var entities =await _Repository.Get().ToListAsync();
            var entitiesDto = entities.Adapt<ICollection<TEntityDto>>();
            return entitiesDto;
        }
    }
}
