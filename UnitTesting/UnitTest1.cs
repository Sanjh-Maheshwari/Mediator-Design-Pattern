using MediatorTaxiCallCenter;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;
using System.Net;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        private ITaxiCallMediator taxiCallMediator = new TaxiCallMediator();

        [TestMethod]
        public void TestMethod1()
        {
            ITaxi taxi = new Taxi("TestCab", 10, true);
            taxiCallMediator.Register(taxi);

            List<ITaxi> taxis = taxiCallMediator.GetTaxis();
            Assert.IsTrue(taxis.Contains(taxi));
        }

        [TestMethod]
        public void TestBooking()
        {
            ITaxi cab1 = new Taxi("Cab1", 5, true);
            ITaxi cab2 = new Taxi("Cab2", 10, true);
            ITaxi cab3 = new Taxi("Cab3", 15, false);

            taxiCallMediator.Register(cab1);
            taxiCallMediator.Register(cab2);
            taxiCallMediator.Register(cab3);

            IPassenger passenger = new Passenger("John", "123 St", 8);
            string output = taxiCallMediator.Book(passenger);

            string expectedMessage = $"The taxi {cab2.Name} is assigned to passanger {passenger.Name} and address {passenger.Address} Passanger {passenger.Name} has booked cab {cab2.Name}";
            Assert.AreEqual(expectedMessage, output);
        }
    }

}