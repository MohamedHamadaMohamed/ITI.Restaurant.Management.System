using MediatR;
using RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries.AdminQueries;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries.AdminQueries;
using RMS.Domain.IRepositories;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Handlers.Queries.AdminQueryHandlers
{
    public class CustomerGetAllClientsQueryHandler : GetAllOrdersQueryHandler<AdminClientDto>, IRequestHandler<AdminGetAllClientsQuery, ICollection<AdminClientDto>>
    {
        public CustomerGetAllClientsQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ICollection<AdminClientDto>> Handle(AdminGetAllClientsQuery request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
