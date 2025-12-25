using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {        
        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse ()
        {
            bool result = PrimeService.IsPrime (1);

            Assert.IsFalse (result, "1 shouldn't be prime");
        }

        [TestMethod]
        [DataRow (-1)]
        [DataRow (0)]
        [DataRow (1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse (int value)
        {
            var result = PrimeService.IsPrime (value);

            Assert.IsFalse (result, $"{value} should not be prime");
        }

        [TestMethod]
        [DataRow (-1, false)]
        [DataRow (0, false)]
        [DataRow (1, false)]
        [DataRow (7, true)]
        [DataRow (13, true)]
        [DataRow (15, false)]
        [DataRow (19, true)]
        [DataRow (22, false)]
        [DataRow (23, true)]
        public void IsPrime_ValuesLessThan2_ReturnFalse (int value, bool output)
        {
            var result = PrimeService.IsPrime (value);

            Assert.AreEqual (result, output, $"{value} {output}");                
        }
    }
}