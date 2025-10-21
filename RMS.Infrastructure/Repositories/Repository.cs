using Microsoft.EntityFrameworkCore;
using RMS.Domain.IRepositories;
using RMS.Domain.Models;
using RMS.Infrastructure.Data.Context;
using System.Linq.Expressions;

namespace RMS.Infrastructure.Repositories
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public void Create(TEntity entity)
        {
            _context.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }


        public IQueryable<TEntity>? Get(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, object>>[]? includeProps = null, bool tracked = true)
        {
            IQueryable<TEntity> query = this._dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProps != null)
            {
                foreach (var include in includeProps)
                {
                    query = query.Include(include);
                }
            }
            if (!tracked)
            {
                query = query.AsNoTracking();
            }

            return query;
        }

        public TEntity? GetById(TKey? id)
        {
            return this.GetItem(filter: e => e.Id != null && e.Id.Equals(id), tracked: true);
        }

        public TEntity? GetItem(Expression<Func<TEntity, bool>>? filter = null, Expression<Func<TEntity, object>>[]? includeProps = null, bool tracked = true)
        {
            return this.Get(filter, includeProps, tracked)?.FirstOrDefault();
        }


        public void Update(TEntity entity)
        {
            _context.Update(entity);
        }

        
    }
}
