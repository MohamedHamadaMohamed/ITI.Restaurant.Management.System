using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries.AdminQueries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Handlers.Queries.AdminQueryHandlers
{
    public class AdminGetCategoryByIdQueryHandler : GetCategoryByIdQueryHandler<AdminCategoryDto>, IRequestHandler<AdminGetCategoryByIdQuery, AdminCategoryDto>
    {
        public AdminGetCategoryByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<AdminCategoryDto> Handle(AdminGetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return base.Handle(request, cancellationToken);
        }
    }
}
