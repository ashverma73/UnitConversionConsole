using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConversionLibrary.Interfaces;
namespace UnitConversionLibrary.Classes
{
   public class DerivedUnit : UnitBase
    {
        public string FormulaInBaseUnit { get; set; }
        public string FormulaInDerivedUnit { get; set; }
    }
}
