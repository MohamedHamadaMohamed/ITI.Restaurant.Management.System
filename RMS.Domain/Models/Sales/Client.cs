using RMS.Domain.Shared;
using System.Net.Sockets;

namespace RMS.Domain.Models.Sales
{
    public class Client : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string ApplicationUserId { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
