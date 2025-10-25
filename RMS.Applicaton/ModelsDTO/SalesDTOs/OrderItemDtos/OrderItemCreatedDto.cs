using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace RMS.Applicaton.Layer.ModelsDTO.ProductionDTOs.OrderItemDtos
{
    public class OrderItemCreatedDto : BaseEntityDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
