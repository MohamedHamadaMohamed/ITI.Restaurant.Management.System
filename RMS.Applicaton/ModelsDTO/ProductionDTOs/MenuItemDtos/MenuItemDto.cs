using RMS.Domain.Shared;

namespace RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.MenuItemDtos
{
    public class MenuItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Money Price { get; set; } = null!;
        public double Discount { get; set; } = 0;

        public string Image { get; set; } = null!;
        public bool IsAvailable { get; set; } = true;
        public int PreparationTimeMinutes { get; set; }

        public int CategoryId { get; set; }
    }
}
