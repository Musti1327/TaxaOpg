using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxaOpg
{
    public class PriceDto
    {
        public double pris { get; set; }

        public double StartPris = 0;

        public VehicleType CarType { get; set; }
        public SetTillaeg tillaeg { get; set; }
    }
}
