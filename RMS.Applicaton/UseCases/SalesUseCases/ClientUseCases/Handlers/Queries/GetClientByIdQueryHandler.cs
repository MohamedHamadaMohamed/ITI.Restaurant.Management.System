using MediatR;
using RMS.Applicaton.Layer.UseCases.Generics.Handlers.Queries;
using RMS.Applicaton.Layer.UseCases.Generics.Queries;
using RMS.Domain.IRepositories;
using RMS.Domain.Models.Production;
using RMS.Domain.Models.Sales;

namespace RMS.Applicaton.Layer.UseCases.SalesUseCases.ClientUseCases.Handlers.Queries
{
    public class GetClientByIdQueryHandler<TEntityDto> : GetItemByIdQueryHandler<Client, int, TEntityDto>, IRequestHandler<GetItemByIdQuery<Client, int, TEntityDto>, TEntityDto>
    {
        public GetClientByIdQueryHandler(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
