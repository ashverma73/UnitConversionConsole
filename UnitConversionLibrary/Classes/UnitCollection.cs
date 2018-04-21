using System;
using System.Collections.Generic;
using UnitConversionLibrary.Interfaces;

namespace UnitConversionLibrary.Classes
{
    public class UnitCollection
    {
       private static Dictionary<string,UnitBase> _baseUnits = new Dictionary<string,UnitBase>(StringComparer.InvariantCultureIgnoreCase);
       private static Dictionary<string,DerivedUnit> _derivedUnits = new Dictionary<string,DerivedUnit>(StringComparer.InvariantCultureIgnoreCase);
        static UnitCollection()
        {
            _baseUnits.Add("metre", new UnitBase { Name= "metre", Symbol = "m", DimensionSymbol = "L", QuantityName = "length" }) ;
            _baseUnits.Add("kilogram", new UnitBase { Name = "kilogram", Symbol = "kg", DimensionSymbol = "M", QuantityName = "mass" });
            _baseUnits.Add("second", new UnitBase { Name = "second", Symbol = "s", DimensionSymbol = "T", QuantityName = "time" });
            _baseUnits.Add("ampere", new UnitBase { Name = "ampere", Symbol = "A", DimensionSymbol = "I", QuantityName = "electric current" });
            _baseUnits.Add("kelvin", new UnitBase { Name = "kelvin", Symbol = "K", DimensionSymbol = "Θ", QuantityName = "thermodynamic temperature" });
            _baseUnits.Add("mole", new UnitBase { Name = "mole", Symbol = "mol", DimensionSymbol = "N", QuantityName = "amount of substance" });
            _baseUnits.Add("candela", new UnitBase { Name = "candela", Symbol = "cd", DimensionSymbol = "J", QuantityName = "luminous intensity" });


            _derivedUnits.Add("radian", new DerivedUnit { Name = "radian", Symbol = "rad", QuantityName = "angle", FormulaInBaseUnit = "m/m" });
            _derivedUnits.Add("steradian", new DerivedUnit { Name = "steradian", Symbol = "sr", QuantityName = "solid angle", FormulaInBaseUnit = "(m*m)/(m*m)" });
            _derivedUnits.Add("hertz", new DerivedUnit { Name = "hertz", Symbol = "Hz", QuantityName = "frequency", FormulaInBaseUnit = "1/s" });
            _derivedUnits.Add("newton", new DerivedUnit { Name = "newton", Symbol = "N", QuantityName = "force, weight", FormulaInBaseUnit = "(kg*m)/(s*s)" });
            _derivedUnits.Add("pascal", new DerivedUnit { Name = "pascal", Symbol = "Pa", QuantityName = "pressure, stress", FormulaInBaseUnit = "(kg)/(m*s*s)", FormulaInDerivedUnit = "N/(m*m)" });
            _derivedUnits.Add("joule", new DerivedUnit { Name = "joule", Symbol = "J", QuantityName = "energy, work, heat", FormulaInBaseUnit = "(kg*m*m)/(s*s)", FormulaInDerivedUnit = "N*m" });
            _derivedUnits.Add("watt", new DerivedUnit { Name = "watt", Symbol = "W", QuantityName = "power, radiant flux", FormulaInBaseUnit = "(kg*m*m)/(s*s*s)", FormulaInDerivedUnit = "J/s" });
            _derivedUnits.Add("surface density", new DerivedUnit { Name = "surface density", Symbol = "rhoA", QuantityName = "kilogram per square metre", FormulaInBaseUnit = "kg/(m*m)" });
            _derivedUnits.Add("current density", new DerivedUnit { Name = "current density", Symbol = "	j", QuantityName = "ampere per square metre", FormulaInBaseUnit = "A/(m*m)" });
            _derivedUnits.Add("speed", new DerivedUnit { Name = "speed", Symbol = "v", QuantityName = "meter per second", FormulaInBaseUnit = "m/s" });
            _derivedUnits.Add("volume", new DerivedUnit { Name = "volume", Symbol = "V", QuantityName = "cubic meter", FormulaInBaseUnit = "m * m * m" });
            _derivedUnits.Add("area", new DerivedUnit { Name = "area", Symbol = "A", QuantityName = "square meter", FormulaInBaseUnit = "m * m" });
            _derivedUnits.Add("inch", new DerivedUnit { Name = "inch", Symbol = "in", QuantityName = "inch", FormulaInBaseUnit = "m * 39.37007874" });
            _derivedUnits.Add("Yards", new DerivedUnit { Name = "Yards", Symbol = "yds", QuantityName = "yards", FormulaInBaseUnit = "m * 1.093613298" });
            _derivedUnits.Add("feet", new DerivedUnit { Name = "feet", Symbol = "ft", QuantityName = "feet", FormulaInBaseUnit = "m * 3.280839895" });
            _derivedUnits.Add("Miles", new DerivedUnit { Name = "Miles", Symbol = "miles", QuantityName = "Miles", FormulaInBaseUnit = "m * 0.0006213711922" });
        }

        public IBaseUnit GetUnit(string key)
        {
            key = key.ToLower();
            var retval = GetUnitfromList(key);
            if (retval != null)
                return retval;
            key = key.TrimEnd('s');
            retval = GetUnitfromList(key);
            if (retval != null)
                return retval;
            key = key.TrimEnd('e');
            retval = GetUnitfromList(key);
            if (retval != null)
                return retval;
            return null;
        }
        private IBaseUnit GetUnitfromList(string key)
        {
            if (_baseUnits.ContainsKey(key))
                return _baseUnits[key];
            if (_derivedUnits.ContainsKey(key))
                return _derivedUnits[key];
            return null;

        }


       
    }
    
}
