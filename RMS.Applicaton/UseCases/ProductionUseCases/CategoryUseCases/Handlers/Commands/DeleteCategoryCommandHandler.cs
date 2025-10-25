using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Handlers.Commands
{
    public class DeleteCategoryCommandHandler : DeleteCommandHandler<Category, int>, IRequestHandler<DeleteCategoryCommand, bool>
    {
        public DeleteCategoryCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);

        }
    }
}
