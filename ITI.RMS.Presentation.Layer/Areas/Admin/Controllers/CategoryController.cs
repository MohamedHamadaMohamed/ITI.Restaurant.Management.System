using MediatR;
using Microsoft.AspNetCore.Mvc;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Applicaton.Layer.UseCases.ProductionUseCases.CategoryUseCases.Queries.AdminQueries;
using RMS.Domain.Models.Production;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Presentation.Layer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [Route($"{nameof(Admin)}/{nameof(Category)}")]
    public class CategoryController : Controller
    {
        
        private readonly IMediator _Mediator;

        public CategoryController(IMediator mediator)
        {
            _Mediator = mediator;
        }
        [HttpGet]
        [Route(nameof(Index))]
        public async Task<IActionResult> Index()
        {
            var query = new AdminGetAllCategoriesQuery();
            var categories = await _Mediator.Send(query);
            return Json(categories);
        }
       




    }
}
