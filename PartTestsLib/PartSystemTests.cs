using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartLib;
using System.Diagnostics;
using System.Collections.Generic;

namespace PartTestsLib
{
    [TestClass]
    public class PartSystemTests
    {
        [TestMethod]
        public void TwoParts()
        {
            var sut = new PartSystem();
            var p1 = new Part("A", "1");
            var p2 = new Part("B", "2");
            var vd = new Accountibility(p1, p2, "VD");
            var employer = new Accountibility(p2, p1, "Arbetsgivare");
            sut.AddPart(p1);
            sut.AddPart(p2);
            sut.AddAccountibility(vd);
            sut.AddAccountibility(employer);
            int actual = sut.NumberOfParts;
            Assert.AreEqual(2, actual);
            actual = sut.NumberOfAccountabilites;
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void ResponsibilitiesForGivenPart()
        {
            var sut = new PartSystem();
            var p1 = new Part("A", "1");
            var p2 = new Part("B", "2");
            var vd = new Accountibility(p1, p2, "VD");
            var employer = new Accountibility(p2, p1, "Arbetsgivare");
            sut.AddPart(p1);
            sut.AddPart(p2);
            sut.AddAccountibility(vd);
            sut.AddAccountibility(employer);
            List<Accountibility> accability = sut.ResponsibilitesByParty(p2);
            foreach (var acc in accability)
            {
                Debug.WriteLine(acc.ToString());
            }
            Assert.AreEqual(1, accability.Count);
        }
    }
}
