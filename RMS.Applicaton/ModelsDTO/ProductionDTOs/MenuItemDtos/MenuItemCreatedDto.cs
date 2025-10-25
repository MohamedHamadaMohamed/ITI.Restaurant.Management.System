﻿namespace RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.MenuItemDtos
{
    public class MenuItemCreatedDto : BaseEntityDto
    {


        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
