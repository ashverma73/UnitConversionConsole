using System;
using System.Collections.Generic;
using UnitConversionLibrary.Interfaces;

namespace UnitConversionLibrary.Classes
{
    public class UnitCollection
    {
        private static object lockObj = new object();
       private static Dictionary<string,UnitBase> _baseUnits = new Dictionary<string,UnitBase>(StringComparer.InvariantCultureIgnoreCase);
       private static Dictionary<string,DerivedUnit> _derivedUnits = new Dictionary<string,DerivedUnit>(StringComparer.InvariantCultureIgnoreCase);
       static UnitCollection()
        {
            _baseUnits.Add("metre", new UnitBase { Name= "metre", Symbol = "m", DimensionSymbol = "L", QuantityName = "length" }) ;
            _baseUnits.Add("bit", new UnitBase { Name = "bit", Symbol = "bit", DimensionSymbol = "data", QuantityName = "data" });


          
            _derivedUnits.Add("inch", new DerivedUnit { Name = "inch", Symbol = "in", QuantityName = "length", multiplier = 39.37007874 });
            _derivedUnits.Add("Yards", new DerivedUnit { Name = "Yards", Symbol = "yds", QuantityName = "length", multiplier = 1.093613298 });
            _derivedUnits.Add("feet", new DerivedUnit { Name = "feet", Symbol = "ft", QuantityName = "length", multiplier =  3.280839895 });
            _derivedUnits.Add("miles", new DerivedUnit { Name = "miles", Symbol = "miles", QuantityName = "length", multiplier =  0.0006213711922 });
            _derivedUnits.Add("byte", new DerivedUnit { Name = "byte", Symbol = "B", QuantityName = "data", multiplier = 0.125 });
           
        }
       

        public static IBaseUnit GetUnit(string key)
        {
            lock (lockObj)
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
        }
        private static IBaseUnit GetUnitfromList(string key)
        {
            if (key == "meter")
                key = "metre";
            if (_baseUnits.ContainsKey(key))
                return _baseUnits[key];
            if (_derivedUnits.ContainsKey(key))
                return _derivedUnits[key];
            return null;

        }


       
    }
    
}
