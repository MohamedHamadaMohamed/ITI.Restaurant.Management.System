using RMS.Domain.IRepositories.IRmsRepositories.IProductionRepositories;
using RMS.Domain.Models.Production;
using RMS.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Repositories.RmsRepositories.ProductionRepositories
{
    internal class MenuItemRepository : Repository<MenuItem, int>, IMenuItemRepository
    {
        public MenuItemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
