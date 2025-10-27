using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries.AdminQueries
{
    public class AdminGetAllClientsQuery : GetAllOrdersQuery<AdminClientDto>
    {
    }
}
