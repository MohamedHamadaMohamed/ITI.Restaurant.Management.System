using RMS.Domain.IRepositories;
using RMS.Infrastructure.Data.Context;

namespace RMS.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        private readonly ApplicationDbContext _Context;
        public UnitOfWork(ApplicationDbContext Context)
        {
            _Context = Context;

        }
        public int Commit()
        {
            return _Context.SaveChanges();
        }
        public void Dispose()
        {
            this._Context.Dispose();
        }
    }
}
