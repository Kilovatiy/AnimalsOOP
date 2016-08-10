using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalModel.CertainAnimal;

namespace AnimalModelTests
{
    [TestClass]
    public class ScreamTests
    {
        [TestMethod]
        public void CatScream()
        {
            Cat cat = new Cat("Dusia", 10);
            Assert.IsTrue(cat.Scream().Length == "Meow".Length*5);
        }

        [TestMethod]
        public void DogScream()
        {
            Dog dog = new Dog("Rex", 20);
            Assert.IsTrue(dog.Scream().Length == "Bow".Length*11);
        }
    }
}
