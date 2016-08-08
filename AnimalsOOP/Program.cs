using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_test.abstraction;

namespace test_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List <BaseAnimal> animals = new List<BaseAnimal>();
            AnimalFamily dogsFamily = new AnimalFamily("DOGS", new BarkShout());
            AnimalFamily catsFamily = new AnimalFamily("CATS", new MeowShout());
            Dog sharik = new Dog("Шарик", 10, dogsFamily);
            Cat barsik = new Cat("Пушок", 2, catsFamily);
            Wolf wolf = new Wolf("Волк", 12, dogsFamily);
            Tiger tiger = new Tiger("Igor",25, catsFamily);
            animals.Add(sharik);
            animals.Add(barsik);
            animals.Add(wolf);
            animals.Add(tiger);
            
            foreach (var a in animals)
            {
                a.Shout();
            }
            Console.ReadLine();
        }        
    }

    
}
