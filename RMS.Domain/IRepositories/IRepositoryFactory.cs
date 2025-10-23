using RMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.IRepositories
{
    public interface IRepositoryFactory
    {
        IRepository<TEntity, TKey> GetRepository<TEntity, TKey>()
           where TEntity : BaseEntity<TKey>;
    }
}
