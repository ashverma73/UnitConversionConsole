using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConversionLibrary.Classes;

namespace UnitConversionLibraryTest
{
    [TestClass]
    public class UnitTestConversionLibrary
    {
        UnitConverter uc = new UnitConverter();
        [TestMethod]
        public void TestNullInput()
        {
            var ans=uc.Convert(null, null);
            Assert.Equals(ans, "Input values cannot be null");
        }

        [TestMethod]
        public void TestInput()
        {
            var ans = uc.Convert("12 inches", "feet");
            Assert.AreSame(ans, "1 feet");
            
        }
    }
}
