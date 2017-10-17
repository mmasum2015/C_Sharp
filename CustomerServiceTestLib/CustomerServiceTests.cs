using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerServiceLIb;
using System.Diagnostics;

namespace CustomerServiceTestLib
{
    [TestClass]
    public class CustomerServiceTests
    {
        [TestMethod]
        public void CompletFlow()
        {
            var sut = new CustomerServices();
            var ticketId = sut.EnterTicket("tests@tests.com", "Testing", new DateTime(2017, 10, 1), "My first offer is still valid");
            var ticket2Id = sut.EnterTicket("test2@test2.com", "Testing", new DateTime(2017, 10, 1), "My coffee pot is malfunctioning");
            bool offerExists = false;
            do
            {
                offerExists = sut.OfferExists(ticketId);
                sut.MakeOffer(ticketId, "Testsäljare", 1000M);
                sut.MakeOffer(ticket2Id, "Oopsie", 2000M);
            } while (!offerExists);
            var offer = sut.Offer(ticketId);
            var offer2 = sut.Offer(ticket2Id);
            Debug.WriteLine($"{offer.Salesperson} {offer.Price}");
            offer.Accept();
            offer2.Accept();
            sut.ResolveTicket(ticketId);
            sut.ResolveTicket(ticket2Id);
            var invoice = sut.Invoice("test@test.com");
            Assert.AreEqual(1000M, invoice.Total);
            var invoice2 = sut.Invoice("test2@test2.com");
            Assert.AreEqual(2000M, invoice2.Total);
        }
    }
}
