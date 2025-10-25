using RMS.Domain.Shared;

namespace RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.ClientDtos
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string ApplicationUserId { get; set; } = null!;

    }
}
