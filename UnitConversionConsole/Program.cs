using System;

using UnitConversionLibrary.Classes;

namespace UnitConversionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitConverter up = new UnitConverter();
            Console.WriteLine(up.Convert("1 meter", "feet"));
            Console.WriteLine(up.Convert("3 kiloinches", "meter"));
            Console.WriteLine(up.Convert("1000000 bytes", "Gigabit",6));
            Console.WriteLine(up.Convert("1 bytes", "bit"));
            Console.WriteLine(up.Convert("1 bytes", null));
            Console.WriteLine(up.Convert("12 inches", "feet"));
            Console.WriteLine(up.Convert("12 feet", "inches"));
            Console.WriteLine(up.Convert("12 nsnt", "inches"));
            Console.WriteLine(up.Convert("1000 meter", "Kilometer"));
            System.Console.ReadKey();
        }
    }
}
