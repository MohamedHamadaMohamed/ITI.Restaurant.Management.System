using Mapster;
using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries
{
    public class GetItemByIdQueryHandler<TEntity, TKey, TRepository, TEntityDto> : IRequestHandler<GetItemByIdQuery<TEntity, TKey, TRepository, TEntityDto>, TEntityDto> where TEntity : BaseEntity<TKey>
    {
        private readonly IRepository<TEntity, TKey> _Repository;

        public GetItemByIdQueryHandler(IRepository<TEntity, TKey> repository)
        {

            _Repository = repository;
        }

        public Task<TEntityDto> Handle(GetItemByIdQuery<TEntity, TKey, TRepository, TEntityDto> request, CancellationToken cancellationToken)
        {
            var entity = _Repository.GetById(request.Id);
            var entityDto = entity.Adapt<TEntityDto>();
            return Task.FromResult(entityDto);
        }
    }
}
