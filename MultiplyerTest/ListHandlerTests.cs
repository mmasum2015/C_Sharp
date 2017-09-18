using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplyerLib;

namespace MultiplyerTest
{
    [TestClass]
    public class ListHandlerTests
    {
        [TestMethod]
        public void AddFiveStrings()
        {
            //Arrange
            ListHandler sut = new ListHandler();

            //Act
            sut.AddFiveStrings();

            //Assert
            Assert.AreEqual(5, sut.List.Count);
        }

        [TestMethod]
        public void RemoveThirdString()
        {
            ListHandler sut = new ListHandler();
            sut.AddFiveStrings();
            string fourthString = sut.List[3];
            sut.RemoveThirdString();
            Assert.AreEqual(4, sut.List.Count);
            Assert.AreEqual(fourthString, sut.List[2]);
        }

        [TestMethod]
        public void Sort()
        {
            ListHandler sut = new ListHandler();
            sut.List.Add("Masum");
            sut.List.Add("Mattias");
            sut.List.Add("Jahurul");
            sut.Sort();
            Assert.AreEqual("Jahurul", sut.List[0]);
        }
    }
}
