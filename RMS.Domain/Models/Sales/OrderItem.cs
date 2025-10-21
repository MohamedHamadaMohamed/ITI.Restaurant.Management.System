using RMS.Domain.Models.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Models.Sales
{
    public class OrderItem : BaseEntity<int>
    {
        public int Quantity { get; set; }
        public int MenuItemId { get; set; }

        public MenuItem MenuItem { get; set; } = new MenuItem();

        public int OrderId { get; set; }

        public Order Order { get; set; } = new Order();

        public ICollection<OrderItemStaff> OrderItemStaffs { get; set; } = new List<OrderItemStaff>();
    }
}
