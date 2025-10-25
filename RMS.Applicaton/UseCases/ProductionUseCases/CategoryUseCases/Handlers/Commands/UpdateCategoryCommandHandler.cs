using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Handlers.Commands
{
    public class UpdateCategoryCommandHandler : UpdateCommandHandler<Category, int, AdminCategoryDto>, IRequestHandler<UpdateCategoryCommand, bool>
    {
        public UpdateCategoryCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
