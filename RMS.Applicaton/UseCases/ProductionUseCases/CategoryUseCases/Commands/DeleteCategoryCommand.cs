using RMS.Applicaton.Layer.UseCases.Generics.Commands;
using RMS.Domain.Models.Production;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Commands
{
    public class DeleteCategoryCommand : DeleteCommand<Category, int>
    {
        public DeleteCategoryCommand(int id) : base(id)
        {
        }
    }
}
