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
    public class PassengerTests
    {
        private Passenger fp;

        [SetUp]
        public void Setup()
        {
            fp = new FakePassenger("FakeFname", "FakeLname", "FakeGender", "FakeTicketType");
        }

        [Test]
        [Ignore("Test To Ignore")]
        public void Passenger_Test_To_Ignore()
        {

        }

        [Test]
        public void Passenger_Constructor_IsCalled_AtrributesSet()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual("FakeFname", fp.fname);
            Assert.AreEqual("FakeLname", fp.lname);
            Assert.AreEqual("FakeGender", fp.getGender());
            Assert.AreEqual("FakeTicketType", fp.getTicketType());
        }

        [Test]
        public void Passenger_GetTicketType_IsCalled()
        {
            // Arrange

            // Act
            fp.getTicketType();

            // Assert
            Assert.AreEqual("FakeTicketType", fp.getTicketType());

        }
    }
}