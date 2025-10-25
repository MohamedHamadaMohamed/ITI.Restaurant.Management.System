using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Production;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Commands
{
    public class UpdateCategoryCommand : UpdateCommand<Category, int, AdminCategoryDto>
    {
        public UpdateCategoryCommand(AdminCategoryDto entityDto) : base(entityDto)
        {
        }
    }
}
