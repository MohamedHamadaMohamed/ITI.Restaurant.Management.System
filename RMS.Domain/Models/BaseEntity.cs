using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Models
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; } = default!;
        public string CreatedBy { get; set; } = default!;
        public string UpdatedBy { get; set;} = default!;
        public string DeletedBy { get; set;} = default!;
        public DateTime CreatedAt { get; set; } = default!;
        public DateTime UpdatedAt { get; set;} = default;
        public DateTime? DeletedAt { get; set; } = null;
        public bool IsDeleted { get; set; } = false;



    }
}
