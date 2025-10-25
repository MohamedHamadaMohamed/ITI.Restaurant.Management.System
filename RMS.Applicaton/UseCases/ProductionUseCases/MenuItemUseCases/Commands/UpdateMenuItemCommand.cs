using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Production;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Commands
{
    public class UpdateMenuItemCommand : UpdateCommand<MenuItem, int, AdminMenuItemDto>
    {
        public UpdateMenuItemCommand(AdminMenuItemDto entityDto) : base(entityDto)
        {
        }
    }
}
