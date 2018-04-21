using System;

using UnitConversionLibrary.Classes;

namespace UnitConversionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitConverter up = new UnitConverter();
            Console.WriteLine(up.Convert("1 centimeter", "feet"));
        }
    }
}
