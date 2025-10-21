using Microsoft.AspNetCore.Identity;
using RMS.Domain.Models.Sales;

namespace RMS.Infrastructure.Data.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public ICollection<Client> Clients { get; set; } = new List<Client>();
    }
}
