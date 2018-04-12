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
    public class DriverTests
    {
        private Driver fd;

        [SetUp]
        public void Setup()
        {
            fd = new FakeDriver("FakeFirstName", "FakeLastName", "FakeGender", "FakeLicence");
        }

        [Test]
        [Ignore("Test To Ignore")]
        public void Driver_Test_To_Ignore()
        {

        }
        [Test]
        public void Driver_Constructor_IsCalled_AttributesSet()
        {
            Assert.AreEqual("FakeFirstName", fd.fname);
            Assert.AreEqual("FakeLastName", fd.lname);
            Assert.AreEqual("FakeGender", fd.getGender());
            Assert.AreEqual("FakeLicence", fd.getLicenceType());
        }

        [Test]
        public void Driver_getLicenceType_IsCalled()
        {
            // Act
            fd.getLicenceType();

            // Assert
            Assert.AreEqual("FakeLicence", fd.getLicenceType());

        }
    }
}