using MediatR;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Queries.CustomerQueries;
using RMS.Applicaton.Layer.UseCases.SalesUseCases.OrderUseCases.Queries.CustomerQueries;
using RMS.Domain.IRepositories;
using RMS.Presentation.Layer.Areas.Customer.Models;



namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Queries.CustomerQueryHandlers
{
    public class CustomerGetAllClientsQueryHandler : GetAllClientsQueryHandler<CustomerClientDto>, IRequestHandler<CustomerGetAllClientsQuery, ICollection<CustomerClientDto>>
    {
        public CustomerGetAllClientsQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ICollection<CustomerClientDto>> Handle(CustomerGetAllClientsQuery request, CancellationToken cancellationToken)
        {
            return await base.Handle(request, cancellationToken);
        }
    }
}
