using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConversionLibrary.Interfaces;
using System.Reflection;
using System.Text.RegularExpressions;

namespace UnitConversionLibrary.Classes
{
    public struct Data
    {
        public IBaseUnit unit;
        public Prefix prefix;
        public double value;
        public string error;
    }
    public class UnitParser
    {
        public Data Parse(string value, bool ignoreNumber = false)
        {
            Data data = new Data();
            Type myType = typeof(PrefixMultipliers);

            // Get the fields of the specified class.
            var fields = myType.GetFields();
            var myField = fields.Select(p => p.Name).ToArray();
            if (!ignoreNumber)
            {
                try
                {
                    var resultString = Regex.Match(value, @"\d+").Value;
                    data.value = double.Parse(resultString);
                    value = value.Replace(resultString, "").Trim();
                }
                catch (Exception ex)
                {
                    data.error = ex.Message;
                    return data;
                }

            }
                // now check for prefixes
                var prefixes = myField.Where(p => value.StartsWith(p,StringComparison.CurrentCultureIgnoreCase));
                if (prefixes != null && prefixes.Count() > 0)
                {
                    var m =  fields.First(j => j.Name == prefixes.First());
                    data.prefix = (Prefix) m.GetValue(null);
                    value = value.Substring(data.prefix.Name.Length);
                }
                
                data.unit = UnitCollection.GetUnit(value);
        
            return data;
        }

    }
}
