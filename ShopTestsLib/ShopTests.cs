using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopLib;

namespace ShopTestsLib
{
    [TestClass]
    public class ShopTests
    {
        [TestMethod]
        public void Count()
        {
            //Arrange
            var sut = new ShopItem();
            //Act
            sut.AddClass("Biscuits", 20);
            sut.AddClass("Cook", 30);
            sut.AddClass("Milk", 20);
            sut.AddClass("Rice", 10);
            sut.AddClass("Rice", 20);

            //Assert
            Assert.AreEqual(4, sut.TotalItem);
            Assert.AreEqual(100, sut.Prices);



        }
    }
}
