using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.CategoryDtos;
using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Production;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Commands
{
    public class CreateCategoryCommand : CreateCommand<Category,int,AdminCategoryDto,CategoryCreatedDto>
    {
    }
}
