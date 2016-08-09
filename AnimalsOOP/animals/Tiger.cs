using System;

namespace test_test
{
    public class Tiger:BaseAnimal
    {
        public Tiger(string name, decimal weight, AnimalFamily family) : base(name, weight, family) {
            base.ShoutStrength = CountShoutStrength();
        }
        public Tiger(){}
        public decimal CountShoutStrength()
        {
            base.ShoutStrength = Math.Round(Weight * 0.5m, 0);
            return base.ShoutStrength;
        }

    //    public override void Shout()
    //    {
    //        for (int i = 0; i < CountShoutStrength(); i++)
    //            family.Shout();
    //    }
    }
}