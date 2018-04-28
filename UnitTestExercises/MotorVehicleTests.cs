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
        public void MotorVehicle_Constructor_IsCalled_AttributesSet()
        {
            Assert.AreEqual(100, mv.maxFuel);
            Assert.AreEqual(50, mv.currentFuel);
            Assert.AreEqual(2, mv.litresPerKM);
        }
        [Test]
        public void MotorVehicle_getFuelRemaining_IsCalled()
        {
            mv.getFuelRemaining();
            Assert.AreEqual(50, mv.getFuelRemaining());
        }
        [Test]
        public void MotorVehicle_refuel_VehicleHasRoom()
        {
            mv.refuel(50);

            Assert.AreEqual(100, mv.currentFuel);
        }
        [Test]
        public void MotorVehicle_refuel_VehicleDoesNotHaveRoom()
        {
            Assert.That(() => mv.refuel(51), Throws.Exception);
        }
        [Test]
        public void MotorVehicle_refuel_AddNegativeValue()
        {
            Assert.That(() => mv.refuel(-1), Throws.Exception);
        }
        [Test]
        public void MotorVehicle_travel_HasEnoughFuel()
        {
            mv.travel(10);
            mv.getFuelRemaining();
            Assert.AreEqual(30, mv.currentFuel);
        }
        [Test]
        public void MotorVehicle_travel_DoesNotHaveEnoughFuel()
        {
            Assert.That(() => mv.travel(26), Throws.Exception);
        }
    }
}