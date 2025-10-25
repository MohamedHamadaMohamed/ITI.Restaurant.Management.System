using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Handlers.Queries.CustomerQueryHandlers
{
    public class CustomerGetCategoryByIdQueryHandler : GetCategoryByIdQueryHandler<CustomerCategoryDto>, IRequestHandler<GetCategoryByIdQuery<CustomerCategoryDto>, CustomerCategoryDto>
    {
        public CustomerGetCategoryByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<CustomerCategoryDto> Handle(GetCategoryByIdQuery<CustomerCategoryDto> request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
