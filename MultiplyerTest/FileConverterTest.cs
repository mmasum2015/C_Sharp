using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplyerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyerTest
{
    [TestClass]

   public class FileConverterTest
    {
        [TestMethod]

        public void mattias_asplund_1971()
        {
            var sut = new FileConverter();
            string actual = sut.Transfer("mattias;asplund; 1971");
            Assert.AreEqual("MATTIAS ASPLUND 46 YEARS OLD",actual);

        }
    }
}
