using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Models.Production
{
    public class Category :BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();


    }
}
