namespace RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.OrderItemStaffDtos
{
    public class OrderItemStaffCreatedDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
