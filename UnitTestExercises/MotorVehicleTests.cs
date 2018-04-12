using DipTestingExercises;
using NUnit.Framework;
using UnitTestExercises.Mocking;

namespace DipTestingExercises.UnitTests
{
    [TestFixture]
    public class MotorVehicleTests
    {
        private MotorVehicle mv;

        [SetUp]
        public void Setup()
        {
          mv = new FakeMotorVehicle(new FakeDriver("FakeFirstName", "FakeLastName", "FakeGender", "FakeLicence"), 100, 50, 2);
        }

        [Test]
        [Ignore("Test To Ignore")]
        public void MotorVehicle_Test_To_Ignore()
        {

        }

        [Test]
        public void MotorVehicle_Constructor_IsCalled_AttributesSet()
        {
            // Arrange

            // Act

            // Assert
            Assert.AreEqual(100, mv.maxFuel);
            Assert.AreEqual(50, mv.currentFuel);
            Assert.AreEqual(2, mv.litresPerKM);


        }

        [Test]
        public void MotorVehicle_getFuelRemaining_IsCalled()
        {
            // Arrange

            // Act
            mv.getFuelRemaining();

            // Assert
            Assert.AreEqual(50, mv.getFuelRemaining());
        }
        [Test]
        public void MotorVehicle_refuel_VehicleHasRoom()
        {
            // Arrange

            // Act
            mv.refuel(50);

            // Assert
            Assert.AreEqual(100, mv.currentFuel);

        }

        [Test]
        public void MotorVehicle_refuel_VehicleDoesNotHaveRoom()
        {

            // Arrange

            // Act

            // Assert

            Assert.That(() => mv.refuel(51), Throws.Exception);

        }

        [Test]
        public void MotorVehicle_refuel_AddNegativeValue()
        {
            // Arrange

            // Act

            // Assert

            Assert.That(() => mv.refuel(-1), Throws.Exception);
        }

        [Test]
        public void MotorVehicle_travel_HasEnoughFuel()
        {
            // Arrange

            // Act
            mv.travel(10);
            mv.getFuelRemaining();

            // Assert

            Assert.AreEqual(30, mv.currentFuel);
        }

        [Test]
        public void MotorVehicle_travel_DoesNotHaveEnoughFuel()
        {
            // Arrange

            // Act

            // Assert

            Assert.That(() => mv.travel(26), Throws.Exception);
        }
    }
}