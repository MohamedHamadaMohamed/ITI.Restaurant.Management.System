using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Queries
{
    public class GetAllClientsQueryHandler<TEntityDto> : GetAllQueryHandler<Client, int, TEntityDto>, IRequestHandler<GetAllQuery<Client, int, TEntityDto>, ICollection<TEntityDto>>
    {
        public GetAllClientsQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
