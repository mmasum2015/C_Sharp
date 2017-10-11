using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeLibTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void RegexTest()
        {

            string input = @"""Mattias Asplund"" 46 35000.00 070-6186120 ";


            EmployeeConverter sut = new EmployeeConverter();
            var results = sut.Convert(input);


        }
    }
}
