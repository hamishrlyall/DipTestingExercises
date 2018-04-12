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
        [Ignore("Test To Ignore")]
        public void Bus_Test_To_Ignore()
        {

        }

        [Test]
        public void Bus_Constructor_IsCalled_AttributesSet()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(1, fb.maxPassengers);
        }

        [Test]
        public void Bus_GetPassengerCount_BusIsEmpty()
        {
            // Arrange

            // Act
            fb.getPassengerCount();

            // Assert
            Assert.AreEqual(0, fb.passengers.Count);

        }

        [Test]
        public void Bus_getPassengerCount_BusHasPassenger()
        {
            // Arrange

            // Act
            fb.passengers.Add(new FakePassenger("FakeFirstName1", "FakeLastName1", "FakeGender", "FakeTicketType"));
            fb.getPassengerCount();

            // Assert
            Assert.AreEqual(1, fb.passengers.Count);
        }

        [Test]
        public void Bus_EmbarkPassenger_BusHasRoom()
        {
            // Arrange

            // Act
            fb.embarkPassenger(fp);

            //Assert
            Assert.Contains(fp, fb.passengers);

        }

        [Test]
        public void Bus_EmbarkPassenger_BusIsFull()
        {
            // Arrange

            // Act
            fb.embarkPassenger(fp);
            try
            {
                fb.embarkPassenger(fp2);
            }
            // Assert
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Contains("Bus is Already Full!"));
            }
            Assert.IsNotEmpty(fb.passengers);

        }
    }
}