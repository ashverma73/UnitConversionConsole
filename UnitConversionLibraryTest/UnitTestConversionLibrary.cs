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
            Assert.AreEqual(ans, "Input values cannot be null");
        }

        [TestMethod]
        public void TestInput()
        {
            var ans = uc.Convert("12 inches", "feet");
            Assert.AreEqual(ans, "1 feet");
        }

        [TestMethod]
        public void TestDataTypeMismatch()
        {
            var ans = uc.Convert("12 inches", "byte");
            Assert.AreEqual(ans, "Please check data as units are not of same type");
        }

        [TestMethod]
        public void TestWrongType()
        {
            var ans = uc.Convert("12 inasches", "byte");
            Assert.AreEqual(ans, "Please check data as it can not be converted");
        }
    }
}
