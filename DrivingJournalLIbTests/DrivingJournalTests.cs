using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrivingJournalLib;

namespace DrivingJournalLIbTests
{
    [TestClass]
    public class DrivingJournalTests
    {
        [TestMethod]
        public void MonthlyStatistics()
        {
            var sut = new DrivingJournal();
            sut.AddEntry(2017, 9, 10, "Drive this month to daliver goods");
            sut.AddEntry(2017, 9, 10, "Drive this month to daliver goods");
            decimal milesDriven = sut.MilesDriven(2017, 9);
            Assert.AreEqual(20M, milesDriven);
        }
    }
}
