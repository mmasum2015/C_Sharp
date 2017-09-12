using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplyerTestLib
{
    [TestClass]
    public class MultiplyerTest
    {
        [TestMethod]
        public void Simple()
        {
            //Arrange
            MultiplyerLib.Multiplyer myMultiplier = new MultiplyerLib.Multiplyer();
            //Act
            var actual = myMultiplier.Simple(20, 20);
            //Assert
            Assert.AreEqual(400, actual);
        }
        //[TestMethod]
        //public void Usingfor()
        //{
        //    //Arrange
        //    MultiplyerLib.Multiplyer myMultiplier = new MultiplyerLib.Multiplyer();
        //    //Act
        //    var actual = myMultiplier.Simple(20, 20);
        //    //Assert
        //    Assert.AreEqual(400, actual);
        //}

        [TestMethod]
        public void While()
        {
            //Arrange
            MultiplyerLib.Multiplyer myMultiplier = new MultiplyerLib.Multiplyer();
            //Act
            var actual = myMultiplier.While(20, 20);
            //Assert
            Assert.AreEqual(400, actual);
        }
    }
}
