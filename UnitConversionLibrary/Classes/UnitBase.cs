using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConversionLibrary.Interfaces;

namespace UnitConversionLibrary.Classes
{
    public class UnitBase :IBaseUnit
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string DimensionSymbol { get; set; }
        public string QuantityName { get; set; }
    }
}
