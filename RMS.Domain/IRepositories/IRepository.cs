using System.Linq.Expressions;

namespace RMS.Domain.IRepositories
{
    public interface IRepository<TEntity,TKey> where TEntity : class
    {
        /*
        CRUD
        C : Create
        R : Retrive
        U : Update 
        D : Delete
        */
        public void Create(TEntity entity);
        public void Update(TEntity entity);

        public void Delete(TEntity entity);
        public IQueryable<TEntity>? Get(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, object>>[]? includeProps = null, bool tracked = true);

        public TEntity? GetItem(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, object>>[]? includeProps = null, bool tracked = true);
            public TEntity? GetById(TKey? id);



    }
}
