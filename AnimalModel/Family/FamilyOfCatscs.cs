using AnimalModel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModel.Family
{
    public class FamilyOfCatscs : AnimalFamily
    {
        public string GetSound()
        {
            return "Meow";
        }

        public string ProduceSound(double strength)
        {
            var scream = new StringBuilder();
            for (int i = 0; i < strength; i++)
            {
                scream.Append(GetSound());
            }

            return scream.ToString();
        }
    }
}
