using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolTestLib
{
    [TestClass]
    public class SchoolSystemTests
    {
        [TestMethod]
        public void Count()
        {
            //Arrange
            var sut = new SchoolSystem();
            //Act
            sut.AddClass("SPO16", 20);
            sut.AddClass("CLOUD16", 30);
            sut.AddClass("SPO16", 20);
            sut.AddClass("C#16", 10);

            //Assert
            Assert.AreEqual(3, sut.ClassCount);
            Assert.AreEqual(80, sut.StudentCount);



        }
    }
}
