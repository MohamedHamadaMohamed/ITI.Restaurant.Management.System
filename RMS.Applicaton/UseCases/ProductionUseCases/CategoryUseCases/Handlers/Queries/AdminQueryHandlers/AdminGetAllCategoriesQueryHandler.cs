using MediatR;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries.AdminQueries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Handlers.Queries.AdminQueryHandlers
{
    public class AdminGetAllCategoriesQueryHandler : GetAllCategoriesQueryHandler<AdminCategoryDto>, IRequestHandler<AdminGetAllCategoriesQuery, ICollection<AdminCategoryDto>>
    {
        public AdminGetAllCategoriesQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ICollection<AdminCategoryDto>> Handle(AdminGetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
