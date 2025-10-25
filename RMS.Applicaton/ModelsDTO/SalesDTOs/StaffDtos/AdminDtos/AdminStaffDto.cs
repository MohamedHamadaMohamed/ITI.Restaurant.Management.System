namespace RMS.Applicaton.Layer.ModelsDTO.SalesDTOs.StaffDtos.AdminDtos
{
    public class AdminStaffDto : StaffDto
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
