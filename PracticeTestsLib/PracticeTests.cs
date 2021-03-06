﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeLib;

namespace PracticeTestsLib
{
    [TestClass]
    public class PracticeTests
    {
        [TestMethod]
        public void GreetingPractice()
        {
            var sut = new PracticeClasss();
            var birthDate = "1971-04-05";
            var name = "Mattias Asplund";
            var phone = "070-6186120";
            
            sut.EnterDetails(birthDate, name, phone);
            var expected = "Mattias Asplund; was born 1971-04-05; and his phone no 070-6186120";
            Assert.AreEqual(expected, sut.Greeting);
        }
    }
}
