namespace RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.StaffDtos
{
    public class StaffCreatedDto : BaseEntityDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
