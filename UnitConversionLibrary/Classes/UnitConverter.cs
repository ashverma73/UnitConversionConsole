namespace UnitConversionLibrary.Classes
{
    public class UnitConverter
    {
        UnitParser _unitParser = new UnitParser();
        public string Convert(string fromUnit, string toUnit)
        {

            if (fromUnit == null || toUnit == null)
                return "Input values cannot be null";
           Data fromUnitData = _unitParser.Parse(fromUnit);
           Data toUnitData = _unitParser.Parse(toUnit,true);

            // Steps 1. Parse fromUnit  
            // Step 2. Parse toUnit
            // Check if Conversion is possible
            // Convert
            // return output or error
            return null;
        }
    }
}
