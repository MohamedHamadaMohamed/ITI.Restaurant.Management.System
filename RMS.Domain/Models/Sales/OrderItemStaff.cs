using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Models.Sales
{
    public class OrderItemStaff
    {
        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; } = null!;
        public int StaffId { get; set; }
        public Staff Staff { get; set; } = null!;

    }
}
