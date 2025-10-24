using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands
{
    public class DeleteCommandHandler<TEntity, TKey> : IRequestHandler<DeleteCommand<TEntity, TKey>, bool> where TEntity : BaseEntity<TKey>
    {
        private readonly IRepository<TEntity, TKey> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<TEntity, TKey>();
        }

        public Task<bool> Handle(Generics.Commands.DeleteCommand<TEntity, TKey> request, CancellationToken cancellationToken)
        {  // soft delete
            var entity = _repository.GetById(request.Id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                var count = _unitOfWork.Commit();
                return Task.FromResult(count > 0);
            }
            return Task.FromResult(false);
        }
    }
}
