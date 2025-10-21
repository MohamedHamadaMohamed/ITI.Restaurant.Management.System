using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models;

namespace RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries
{
    public class GetAllQueryHandler<TEntity, TKey, TRepository, TEntityDto> : IRequestHandler<GetAllQuery<TEntity, TKey, TRepository, TEntityDto>, ICollection<TEntityDto>> where TEntity : BaseEntity<TKey>
    {


        private readonly IRepository<TEntity, TKey> _Repository;

        public GetAllQueryHandler( IRepository<TEntity, TKey> repository)
        {
            
            _Repository = repository;
        }
        public async Task<ICollection<TEntityDto>> Handle(GetAllQuery<TEntity, TKey, TRepository, TEntityDto> request, CancellationToken cancellationToken)
        {
            var entities =await _Repository.Get().ToListAsync();
            var entitiesDto = entities.Adapt<ICollection<TEntityDto>>();
            return entitiesDto;
        }
    }
}
