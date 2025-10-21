using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Shared
{
    public class Money
    {
        public double Price {  get; set; }
        public string Currency { get; set; } = "EGP";
    }
}
