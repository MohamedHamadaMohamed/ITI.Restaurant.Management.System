using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.MenuItemUseCases.Commands
{
    public class DeleteMenuItemCommand : DeleteCommand<MenuItem, int>
    {
        public DeleteMenuItemCommand(int id) : base(id)
        {
        }
    }
}
