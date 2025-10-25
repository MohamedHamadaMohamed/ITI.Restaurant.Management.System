using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries.CustomerQueries
{
    public class CustomerGetCategoryByIdQuery : GetCategoryByIdQuery<CustomerCategoryDto>
    {
        public CustomerGetCategoryByIdQuery(int id) : base(id)
        {
        }
    }
}
