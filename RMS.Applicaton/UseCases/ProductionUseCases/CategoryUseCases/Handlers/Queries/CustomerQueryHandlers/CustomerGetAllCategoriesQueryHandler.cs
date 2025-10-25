using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries.CustomerQueries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;



namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Handlers.Queries.CustomerQueryHandlers
{
    public class CustomerGetAllCategoriesQueryHandler : GetAllCategoriesQueryHandler<CustomerCategoryDto>, IRequestHandler<CustomerGetAllCategoriesQuery, ICollection<CustomerCategoryDto>>
    {
        public CustomerGetAllCategoriesQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ICollection<CustomerCategoryDto>> Handle(CustomerGetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
