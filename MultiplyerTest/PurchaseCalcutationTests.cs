using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplyerLib;
namespace MultiplyerTest
{


    [TestClass]
    public class PurchaseCalcutationTests
    {
        [TestMethod]
        public void ExcludedVAT()
        {
            var sut = new PurchaseCalculation();
            var total = sut.Execute(10, 100.0M, false);
            Assert.AreEqual(1000.0M, total);
        }

        [TestMethod]
        public void IncludedVAT()
        {
            var sut = new PurchaseCalculation();
            var total = sut.Execute(10, 100.0M, true);
            Assert.AreEqual(1250.0M, total);
        }
    }
}
