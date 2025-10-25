using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.ClientDtos;

namespace RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.ClientDtos.AdminDtos
{
    public class AdminClientDto : ClientDto
    {
        public string CreatedBy { get; set; } = default!;
        public string? UpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime CreatedAt { get; set; } = default!;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsActive { get; set; } = true;



    }
}
