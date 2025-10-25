using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;
using RMS.Presentation.Layer.Areas.Admin.Models;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Commands.AdminCommandHandlers
{
    public class AdminUpdateClientCommand : UpdateClientCommand<AdminClientDto>
    {
        public AdminUpdateClientCommand(AdminClientDto entityDto) : base(entityDto)
        {
        }
    }
}
