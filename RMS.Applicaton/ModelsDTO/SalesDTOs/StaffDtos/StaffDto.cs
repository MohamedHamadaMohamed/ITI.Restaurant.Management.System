using RMS.Domain.ValueObjects;

namespace RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.StaffDtos
{
    public class StaffDto
    {
        public int Id { get; set; }
        public Name Name { get; set; } = null!;
        public string? Phone { get; set; }
    }
}
