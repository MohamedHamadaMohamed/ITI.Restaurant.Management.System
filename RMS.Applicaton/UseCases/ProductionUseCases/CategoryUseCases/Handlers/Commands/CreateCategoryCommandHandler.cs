using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.CategoryDtos;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Commands;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Commands;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Handlers.Commands
{
    public class CreateCategoryCommandHandler : CreateCommandHandler<Category, int, AdminCategoryDto, CategoryCreatedDto>, IRequestHandler<CreateCategoryCommand,CategoryCreatedDto>
    {
        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<CategoryCreatedDto> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
