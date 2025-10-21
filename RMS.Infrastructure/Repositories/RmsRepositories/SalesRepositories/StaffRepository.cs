using RMS.Domain.IRepositories.IRmsRepositories.ISalesRepositories;
using RMS.Domain.Models.Sales;
using RMS.Infrastructure.Data.Context;

namespace RMS.Infrastructure.Repositories.RmsRepositories.SalesRepositories
{
    public class StaffRepository : Repository<Staff, int>, IStaffRepository
    {
        public StaffRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
