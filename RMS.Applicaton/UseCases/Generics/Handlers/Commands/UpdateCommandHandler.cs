using Mapster;
using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands
{
    public class UpdateCommandHandler<TEntity, TKey, TEntityDto> : IRequestHandler<UpdateCommand<TEntity, TKey, TEntityDto>, bool> where TEntity : BaseEntity<TKey>
    {
        private readonly IRepository<TEntity, TKey> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<TEntity, TKey>();
        }


        public Task<bool> Handle(UpdateCommand<TEntity, TKey, TEntityDto> request, CancellationToken cancellationToken)
        {
            var entity = request.entityDto.Adapt<TEntity>();
             _repository.Update(entity);
            var count = _unitOfWork.Commit();
            return Task.FromResult(count > 0);
        }
    }
}
