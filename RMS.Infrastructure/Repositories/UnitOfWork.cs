using RMS.Domain.IRepositories;
using RMS.Domain.Models;
using RMS.Infrastructure.Data.Context;

namespace RMS.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        private readonly ApplicationDbContext _Context;
        private readonly IRepositoryFactory _repositoryFactory;
        public UnitOfWork(ApplicationDbContext Context, IRepositoryFactory repositoryFactory)
        {
            _Context = Context;
            _repositoryFactory = repositoryFactory;
        }

       
        public int Commit()
        {
            return _Context.SaveChanges();
        }
        public void Dispose()
        {
            this._Context.Dispose();
        }

        public IRepository<TEntity, TKey> GetRepository<TEntity, TKey>() where TEntity : BaseEntity<TKey>
        {
            return _repositoryFactory.GetRepository<TEntity, TKey>();
        }
    }
}
