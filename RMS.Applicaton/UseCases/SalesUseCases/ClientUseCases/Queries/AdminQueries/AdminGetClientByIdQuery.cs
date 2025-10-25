using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries.AdminQueries
{
    public class AdminGetClientByIdQuery : GetClientByIdQuery<AdminClientDto>
    {
        public AdminGetClientByIdQuery(int id) : base(id)
        {
        }
    }
}
