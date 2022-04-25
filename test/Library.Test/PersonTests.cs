using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }


        [Test]
        public void WithValidName() // Cambiá el nombre para indicar qué estás probando
        {
            string validName = "Anthony";
            Person uno = new Person(validName, "");
            Assert.AreEqual(validName, uno.Name);
        }

        [Test]
        public void WithInvalidName()
        {
            string invalidName = "";
            Person uno = new Person(invalidName, "");
            Assert.AreEqual(null, uno.Name);
        }

        [Test]
        public void WithValidId() 
        {
            const bool validId = true;
            Person uno = new Person("", "1.234.890-4");
            Assert.AreEqual(validId, string.IsNullOrEmpty(uno.ID));
        }

        [Test]
        public void WithInvalidId()
        {
            string invalidId = "1111111111111111111111111111";
            Person uno = new Person("", invalidId);
            Assert.AreEqual(null, uno.ID);
        }
    }
}