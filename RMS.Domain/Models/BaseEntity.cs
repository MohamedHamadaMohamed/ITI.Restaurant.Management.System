using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Models
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; } = default!;
        public string CreatedBy { get; set; } = default!;
        public string? UpdatedBy { get; set;} 
        public string? DeletedBy { get; set;} 
        public DateTime CreatedAt { get; set; } = default!;
        public DateTime? UpdatedAt { get; set;} 
        public DateTime? DeletedAt { get; set; } 
        public bool IsDeleted { get; set; } = false;



    }
}
