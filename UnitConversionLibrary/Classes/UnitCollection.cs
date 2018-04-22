using System;
using System.Collections.Generic;
using UnitConversionLibrary.Interfaces;

namespace UnitConversionLibrary.Classes
{
    public class UnitCollection
    {
        private static object lockObj = new object();
       private static Dictionary<string,IBaseUnit> _Units = new Dictionary<string, IBaseUnit>(StringComparer.InvariantCultureIgnoreCase);
      
       static UnitCollection()
        {
            _Units.Add("metre", new UnitBase { Name= "metre", Symbol = "m", DimensionSymbol = "L", QuantityName = "length" }) ;
            _Units.Add("bit", new UnitBase { Name = "bit", Symbol = "bit", DimensionSymbol = "data", QuantityName = "data" });

            _Units.Add("inch", new DerivedUnit { Name = "inch", Symbol = "in", QuantityName = "length", multiplier = 39.37007874 });
            _Units.Add("Yards", new DerivedUnit { Name = "Yards", Symbol = "yds", QuantityName = "length", multiplier = 1.093613298 });
            _Units.Add("feet", new DerivedUnit { Name = "feet", Symbol = "ft", QuantityName = "length", multiplier =  3.280839895 });
            _Units.Add("miles", new DerivedUnit { Name = "miles", Symbol = "miles", QuantityName = "length", multiplier =  0.0006213711922 });
            _Units.Add("byte", new DerivedUnit { Name = "byte", Symbol = "B", QuantityName = "data", multiplier = 0.125 });
            _Units.Add("area", new DerivedUnit { Name = "area", Symbol = "A", QuantityName = "length", multiplier = 1, Baseformula ="meter * meter" });

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
            if (_Units.ContainsKey(key))
                return _Units[key];
            return null;

        }


       
    }
    
}
