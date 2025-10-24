using RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.CategoryDtos;

namespace RMS.Presentation.Layer.Areas.Admin.Models
{
    public class AdminCategoryDto : CategoryDto
    {
        public string CreatedBy { get; set; } = default!;
        public string UpdatedBy { get; set; } = default!;
        public string DeletedBy { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = default!;
        public DateTime UpdatedAt { get; set; } = default;
        public DateTime? DeletedAt { get; set; } = null;
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;

    }
}
