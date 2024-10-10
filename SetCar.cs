using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxaOpg
{
    internal class SetCar
    {
        public PriceDto GetNormalCarPriceDay()
        {

            var obj = new PriceDto();
            obj.CarType = VehicleType.Normal;
            obj.tillaeg = SetTillaeg.Dag;
            obj.StartPris = 37;
            obj.PrisPrKm = 12.75;

            return obj;
        }
        public PriceDto GetBigCarPriceDay()
        {
            
            {
                var obj = new PriceDto();
                obj.CarType = VehicleType.Big;
                obj.tillaeg = SetTillaeg.Dag;
                obj.StartPris = 77;
                obj.PrisPrKm = 17;

                return obj;
            }

            
        }
        public PriceDto GetNormalCarPriceNight()
        {
            var obj = new PriceDto();
            obj.CarType = VehicleType.Normal;
            obj.tillaeg = SetTillaeg.Dag;
            obj.StartPris = 47;
            obj.PrisPrKm = 16;

            return obj;
        }
        public PriceDto GetBigCarPriceNight()
        {
            var obj = new PriceDto();
            obj.CarType = VehicleType.Normal;
            obj.tillaeg = SetTillaeg.Dag;
            obj.StartPris = 87;
            obj.PrisPrKm = 19;

            return obj;
        }
    }
}
