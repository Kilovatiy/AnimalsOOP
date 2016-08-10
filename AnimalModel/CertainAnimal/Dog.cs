using AnimalModel.Abstraction;
using AnimalModel.Family;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModel.CertainAnimal
{
    public class Dog : FamilyOfDogs, Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Dog(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public double Jump()
        {
            throw new NotImplementedException();
        }

        public string Scream()
        {
            var strength = Math.Round(Weight * 0.5 + 1, 0);
            return base.ProduceSound(strength);
        }
    }
}
