using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using test_test.abstraction;
using test_test.animals;

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
            //something with namespaces
            var s = SerializeAnimalObjects(animals);
            foreach (var a in animals)
            {
                a.Shout();
            }
            Console.ReadLine();
        }

        public static string SerializeAnimalObjects(List<BaseAnimal> toSerialize)
        {
            var animalDerivedTypes = (from lAssembly in AppDomain.CurrentDomain.GetAssemblies()
                             from lType in lAssembly.GetTypes()
                             where typeof(BaseAnimal).IsAssignableFrom(lType)
                             select lType);
                        
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType(), animalDerivedTypes.ToArray());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }
    }

    
}
