using Microsoft.EntityFrameworkCore;
using RMS.Domain.IRepositories;
using RMS.Domain.Models;
using RMS.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Repositories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly ApplicationDbContext _context;
        private readonly Dictionary<string, object> _repositories = new();

        public RepositoryFactory(ApplicationDbContext context)
        {
            _context = context;
        }

        public IRepository<TEntity, TKey> GetRepository<TEntity, TKey>() where TEntity : BaseEntity<TKey>
        {
            var key = typeof(TEntity).Name;
            if (_repositories.ContainsKey(key))
            {
                return (IRepository<TEntity, TKey>)_repositories[key];
            }
            var instance = new Repository<TEntity, TKey>(_context);
            _repositories.Add(key , instance);
            return instance;
        }
    }
}
