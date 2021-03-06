﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartLib;

namespace PartTestsLib
{
    [TestClass]
    public class PartTest
    {
        [TestMethod]
        public void CorrectToString()
        {
            var sut = new Part("Mattias Asplund",
                "19710405-7851");
            Assert.AreEqual("Mattias Asplund (19710405-7851)",
                sut.ToString());
        }
        [TestMethod]
        public void CanHandleThreeAccountabilities()
        {
            var sut = new Part("Mattias Asplund",
                "19710405-7851");
            Assert.AreEqual("Mattias Asplund (19710405-7851)",
                sut.ToString());
        }
    }
}
