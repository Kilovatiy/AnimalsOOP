using System;
using System.Xml.Serialization;
using test_test.abstraction;

namespace test_test
{
    [XmlRoot(Namespace = "abstraction")]
    [XmlInclude(typeof(Dog))]
    [XmlInclude(typeof(Cat))]
    [XmlInclude(typeof(Tiger))]
    [XmlInclude(typeof(Wolf))]
    public abstract class BaseAnimal: IShoutBehaviour
    {
        [XmlElement]
        public string petName { get; set; }
        [XmlElement]
        public decimal Weight { get; set; }
        public AnimalFamily family { get; set; }
        [XmlIgnore]
        public decimal ShoutStrength { get; set; }

        public BaseAnimal() { }
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