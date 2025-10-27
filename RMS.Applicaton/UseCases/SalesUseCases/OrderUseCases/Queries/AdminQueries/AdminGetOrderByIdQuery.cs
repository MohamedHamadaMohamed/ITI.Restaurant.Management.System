using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries.AdminQueries
{
    public class AdminGetOrderByIdQuery : GetOrderByIdQuery<AdminOrderDto>
    {
        public AdminGetOrderByIdQuery(int id) : base(id)
        {
        }
    }
}
