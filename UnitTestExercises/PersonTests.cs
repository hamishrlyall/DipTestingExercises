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
    public class PersonTests
    {
        private Person fp;

        [SetUp]
        public void Setup()
        {
            fp = new FakePerson("FakeFirstName", "FakeLastName", "FakeGender");
        }

        [Test]
        [Ignore("Test To Ignore")]
        public void Person_Test_To_Ignore()
        {

        }
        [Test]
        public void Person_Constructor_IsCalled_AttributesSet()
        {
            // Assert
            Assert.AreEqual("FakeFirstName", fp.fname);
            Assert.AreEqual("FakeLastName", fp.lname);
            Assert.AreEqual("FakeGender", fp.getGender());
        }

        [Test]
        public void Person_getName_IsCalled()
        {
            // Act
            fp.getName();

            // Assert
            Assert.AreEqual("FakeFirstName", fp.fname);
            Assert.AreEqual("FakeLastName", fp.lname);

        }

        [Test]
        public void Person_getGender_IsCalled()
        {
            //Act
            fp.getGender();

            //Assert
            Assert.AreEqual("FakeGender", fp.getGender());
        }
    }
}