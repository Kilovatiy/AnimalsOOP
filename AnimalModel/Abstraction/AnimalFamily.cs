using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModel.Abstraction
{
    public interface AnimalFamily
    {
        string GetSound();
        string ProduceSound(double strength);
    }
}
