using System;

namespace test_test
{
    internal class Cat: BaseAnimal
    {
        public Cat(string name, decimal weight, AnimalFamily family) : base(name, weight, family) {
            base.ShoutStrength = CountShoutStrength();
        }

        public decimal CountShoutStrength()
        {
            base.ShoutStrength = Math.Round(Weight * 0.5m, 0);
            return base.ShoutStrength;
        }

        //public override void Shout()
        //{
        //    for (int i = 0; i < CountShoutStrength(); i++)
        //        family.Shout();
        //}
    }
}