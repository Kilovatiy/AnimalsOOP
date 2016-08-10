using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalModel.Abstraction
{
    public interface Animal
    {
        string Name { get; set; }
        double Weight { get; set; }

        string Scream();
        double Jump();
    }
}
