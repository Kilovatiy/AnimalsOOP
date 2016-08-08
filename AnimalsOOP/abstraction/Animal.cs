using System;
using test_test.abstraction;

namespace test_test
{
    internal abstract class BaseAnimal: IShoutBehaviour
    {
        internal string petName { get; set; }
        internal decimal Weight { get; set; }
        internal AnimalFamily family { get; set; }
        internal decimal ShoutStrength { get; set; }
        
        public BaseAnimal(string name, decimal weight, AnimalFamily family) {
            this.petName = name;
            this.Weight = weight;
            this.family = family;            
        }

        public virtual void Shout()
        {
            Console.WriteLine($"{petName} shouts : ");
            for (int i = 0; i < this.ShoutStrength; i++)
            {
                family.Shout();
            }
            Console.WriteLine("#####");
        }
    }


}