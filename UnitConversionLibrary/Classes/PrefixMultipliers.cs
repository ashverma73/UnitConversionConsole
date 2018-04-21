using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConversionLibrary.Classes
{
    public struct Prefix
    {
       public string Name { get; set; }
       public string Symbol { get; set; }
       public double factor { get; set; }
    }
    public static class PrefixMultipliers
    {
        public static readonly Prefix Yotta = new Prefix { Name ="Yotta", Symbol= "Y", factor= 1e+24 } ;
       
        public static readonly Prefix Zetta = new Prefix { Name = "Zetta", Symbol = "Y", factor = 1e+24 }; 
        public static readonly Prefix Exa = new Prefix { Name = "Exa", Symbol = "Y", factor = 1e+18 }; 
        public static readonly Prefix Peta = new Prefix { Name = "Peta", Symbol = "Y", factor = 1e+15 };
        public static readonly Prefix Terra = new Prefix { Name = "Terra", Symbol = "Y", factor = 1e+12 }; 
        public static readonly Prefix Giga = new Prefix { Name = "Giga", Symbol = "Y", factor = 1e+9 }; 
        public static readonly Prefix Mega = new Prefix { Name = "Mega", Symbol = "Y", factor = 1e+6 }; 
        public static readonly Prefix Kilo = new Prefix { Name = "Kilo", Symbol = "Y", factor = 1e+3 }; 
        public static readonly Prefix Hecto = new Prefix { Name = "Hecto", Symbol = "Y", factor = 1e+2 }; 
        public static readonly Prefix Deca = new Prefix { Name = "Deca", Symbol = "Y", factor = 1e+1 };  
                               
                               
        public static readonly Prefix Deci = new Prefix { Name = "Deci", Symbol = "Y", factor = 1e-2 }; 
        public static readonly Prefix Centi = new Prefix { Name = "Centi", Symbol = "Y", factor = 1e-2 }; 
        public static readonly Prefix Milli = new Prefix { Name = "Milli", Symbol = "Y", factor = 1e-3 }; 
        public static readonly Prefix Micro = new Prefix { Name = "Micro", Symbol = "Y", factor = 1e-6 }; 
        public static readonly Prefix Nano = new Prefix { Name = "Nano", Symbol = "Y", factor = 1e-9 }; 
        public static readonly Prefix Pico = new Prefix { Name = "Pico", Symbol = "Y", factor = 1e-12 };
        public static readonly Prefix Femto = new Prefix { Name = "Femto", Symbol = "Y", factor = 1e-15 }; 
        public static readonly Prefix Atto = new Prefix { Name = "Atto", Symbol = "Y", factor = 1e-18 }; 
        public static readonly Prefix Zeppto = new Prefix { Name = "Zeppto", Symbol = "Y", factor = 1e-21 };
        public static readonly Prefix Yocto = new Prefix { Name = "Yocto", Symbol = "Y", factor = 1e-24 };  
    }
}
