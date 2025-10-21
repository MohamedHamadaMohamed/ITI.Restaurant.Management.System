using RMS.Domain.ValueObjects;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Models.Sales
{
    public class Staff : BaseEntity<int>
    {
        public Name Name { get; set; } = null!;
        public string? Phone { get; set; }

        public ICollection<OrderItemStaff> OrderItemStaffs{ get;set; }= new List<OrderItemStaff>();


    }
}
