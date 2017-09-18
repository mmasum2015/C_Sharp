using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CirkusLib;

namespace CirkusLibTests
{
    [TestClass]
    public class CirkusTest
    {
        [TestMethod]
        public void TestToString()
        {
            //Arrange
            Cirkus sut = new Cirkus("Elefanten");
            Artist clown = new Artist("Clownen Surskratt");
            Artist lindansare = new Artist("Linsdansaren Repo");
            sut.Anställ(clown);
            sut.Anställ(lindansare);
            sut.ArtistUppträdande(clown);
            sut.ArtistUppträdande(lindansare);
            sut.ArtistUppträdande(lindansare);
            //var expected = "Cirkus Elefanten har 2 artister. Clowen Surskratt har uppträtt 1 gång. Linsdansaren Repo har uppträtt 2 ng";
            var expected = "Cirkus Elefanten har 2 artister.";
            //Act
            string actual = sut.ToString();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
