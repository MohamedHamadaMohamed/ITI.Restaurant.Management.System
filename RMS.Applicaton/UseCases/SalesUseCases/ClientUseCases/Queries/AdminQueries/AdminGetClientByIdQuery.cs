using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries.AdminQueries
{
    public class AdminGetClientByIdQuery : GetOrderByIdQuery<AdminClientDto>
    {
        public AdminGetClientByIdQuery(int id) : base(id)
        {
        }
    }
}
