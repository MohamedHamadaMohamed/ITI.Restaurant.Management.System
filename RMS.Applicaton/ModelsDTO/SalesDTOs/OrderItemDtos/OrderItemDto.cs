﻿namespace RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.OrderItemDtos
{
    public class OrderItemDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int MenuItemId { get; set; }
        public int OrderId { get; set; }

    }
}
