using MediatR;
using Microsoft.AspNetCore.Mvc;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.Models.Production;
using RMS.Presentation.Layer.Areas.Admin.Models;
using RMS.Presentation.Layer.Areas.Customer.Models;

namespace RMS.Presentation.Layer.Areas.Customer.Controllers
{
    [Area(nameof(Customer))]
    [Route($"{nameof(Customer)}/{nameof(Category)}")]
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
            var query = new GetAllQuery<Category, int, CustomerCategoryDto>();
            var categories = await _Mediator.Send(query);
            return Json(categories);
        }
    }
}
