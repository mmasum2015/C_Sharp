using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingsSpelLib;

namespace TraniningsSpelTests
{
    [TestClass]
    public class TrainingSpelTest
    {
        [TestMethod]
        public void GameWinner()
        {
            var sut = new Game();

            var result = sut.ThrowDice(4, 3);

            Assert.AreEqual(7, result );
        }
    }
}
