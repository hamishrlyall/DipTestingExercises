using DipTestingExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestExercises.Mocking;

namespace DipTestingExercises.UnitTests
{
    [TestFixture]
    public class BusTests
    {
        private Bus fb;
        private FakePassenger fp;
        private FakeDriver fd;
        private FakePassenger fp2;
        [SetUp]
        public void Setup()
        {
            fb = new FakeBus(new FakeDriver("FakeFirstName", "FakeLastName", "FakeGender", "FakeLicence"), 100, 50, 2, 1);
            fp = new FakePassenger("FakeFirstName", "FakeLastName", "FakeGender", "FakeTicketType");
            fd = new FakeDriver("FakeFirstName", "FakeLastName", "FakeGender", "FakeLicence");
            fp2 = new FakePassenger("FakeFirstName2", "FakeLastName2", "FakeGender", "FakeTicketType");
        }
        [Test]
        public void Bus_Constructor_IsCalled_AttributesSet()
        {
            Assert.AreEqual(1, fb.maxPassengers);
        }

        [Test]
        public void Bus_GetPassengerCount_BusIsEmpty()
        {
            fb.getPassengerCount();
            Assert.AreEqual(0, fb.passengers.Count);
        }

        [Test]
        public void Bus_getPassengerCount_BusHasPassenger()
        {
            fb.passengers.Add(new FakePassenger("FakeFirstName1", "FakeLastName1", "FakeGender", "FakeTicketType"));
            fb.getPassengerCount();
            Assert.AreEqual(1, fb.passengers.Count);
        }
        [Test]
        public void Bus_EmbarkPassenger_BusHasRoom()
        {
            fb.embarkPassenger(fp);
            Assert.Contains(fp, fb.passengers);
        }
        [Test]
        public void Bus_EmbarkPassenger_BusIsFull()
        {
            try
            {
                fb.embarkPassenger(fp2);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Contains("Bus is Already Full!"));
            }
            Assert.IsNotEmpty(fb.passengers);
        }
    }
}