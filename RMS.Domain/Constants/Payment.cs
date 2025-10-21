using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Domain.Constants
{
    public record Payment(string Value)
    {
        public static readonly Payment Credit = new(nameof( Credit));
        public static readonly Payment Cash = new(nameof(Cash));

        public override string ToString() => $"{Value}";
    }
}
