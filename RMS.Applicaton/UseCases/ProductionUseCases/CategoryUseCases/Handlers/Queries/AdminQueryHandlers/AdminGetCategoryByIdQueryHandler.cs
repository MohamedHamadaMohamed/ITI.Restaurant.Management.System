using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Handlers.Queries.AdminQueryHandlers
{
    public class CustomerGetCategoryByIdQueryHandler : GetCategoryByIdQueryHandler<AdminCategoryDto>, IRequestHandler<GetCategoryByIdQuery<AdminCategoryDto>, AdminCategoryDto>
    {
        public CustomerGetCategoryByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<AdminCategoryDto> Handle(GetCategoryByIdQuery<AdminCategoryDto> request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
