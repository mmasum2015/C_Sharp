using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingsSpelLib;
using System.Diagnostics;

namespace TraniningsSpelTests
{
    [TestClass]
    public class TrainingSpelTest
    {
        //[TestMethod]
        //public void GameWinner()
        //{
        //    var sut = new Game();

        //    var result = sut.ThrowDice(4, 3);

        //    Assert.AreEqual(7, result );
        //}

        [TestMethod]
        public void Throws_Seven_Wins()
        {
            Random random = new Random();
            var sut = new Game(random);
            while (!sut.IsWinner)
            {
                sut.ThrowDices();
                Debug.WriteLine(sut.ToString());
            }
            Debug.WriteLine($"Won after {sut.ThrowsMade} throws.");
            Assert.AreEqual(7, sut.NumberOfPoints);
        }
    }  

}
