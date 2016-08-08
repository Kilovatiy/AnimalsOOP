using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_test.abstraction
{
    public interface IShoutBehaviour
    {
        void Shout();
    }

    public class BarkShout : IShoutBehaviour
    {
        public void Shout()
        {
            Console.WriteLine("Bark!");
        }
    }

    public class MeowShout : IShoutBehaviour
    {
        public void Shout()
        {
            Console.WriteLine("MEOW!");
        }
    }
}
