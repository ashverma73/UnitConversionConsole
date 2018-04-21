namespace UnitConversionLibrary.Classes
{
    public class UnitConverter
    {
        UnitParser _unitParser = new UnitParser();
        public string Convert(string fromUnit, string toUnit, int decimalplaces =2)
        {
            if (fromUnit == null || toUnit == null)
                return "Input values cannot be null";

           Data fromUnitData = _unitParser.Parse(fromUnit);
           Data toUnitData = _unitParser.Parse(toUnit,true);

            if (fromUnitData.unit == null || toUnitData.unit == null)
                return "Please check data as it can not be converted";

            if ((fromUnitData.unit as UnitBase)?.QuantityName != (toUnitData.unit as UnitBase)?.QuantityName)
                return "Please check data as units are not of same type";

            var unitvalinbase = fromUnitData.value;

            if (fromUnitData.prefix.Name != null && fromUnitData.prefix.factor != 0)
                unitvalinbase *= fromUnitData.prefix.factor;

            if ((fromUnitData.unit as DerivedUnit) != null)
                unitvalinbase /= (fromUnitData.unit as DerivedUnit).multiplier;
            
            if (toUnitData.prefix.Name != null && toUnitData.prefix.factor != 0)
                unitvalinbase /= toUnitData.prefix.factor;

            if ((toUnitData.unit as DerivedUnit) != null)
                unitvalinbase *= (toUnitData.unit as DerivedUnit).multiplier;
           
            return System.Math.Round(unitvalinbase,decimalplaces).ToString() + " " + (toUnitData.prefix.Name ?? "") + (toUnitData.unit as UnitBase).Name;
        }
    }
}
