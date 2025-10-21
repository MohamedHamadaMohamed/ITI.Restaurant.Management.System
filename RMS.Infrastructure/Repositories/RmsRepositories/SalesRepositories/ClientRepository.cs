using RMS.Domain.IRepositories.IRmsRepositories.ISalesRepositories;
using RMS.Domain.Models.Sales;
using RMS.Infrastructure.Data.Context;

namespace RMS.Infrastructure.Repositories.RmsRepositories.SalesRepositories
{
    public class ClientRepository : Repository<Client, int>, IClientRepository
    {
        public ClientRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
