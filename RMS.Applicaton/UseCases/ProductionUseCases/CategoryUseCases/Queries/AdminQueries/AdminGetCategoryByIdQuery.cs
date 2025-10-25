using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries.AdminQueries
{
    public class AdminGetCategoryByIdQuery : GetCategoryByIdQuery<AdminCategoryDto>
    {
        public AdminGetCategoryByIdQuery(int id) : base(id)
        {
        }
    }
}
