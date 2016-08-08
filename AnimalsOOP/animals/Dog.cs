﻿using System;

namespace test_test
{
    internal class Dog:BaseAnimal
    {
        public Dog(string name, decimal weight, AnimalFamily family) : base(name, weight, family) {
            base.ShoutStrength = CountShoutStrength();
        }

        public decimal CountShoutStrength(){
            decimal _ShoutStrength = Math.Round(Weight * 0.5m + 1,0);
            return _ShoutStrength;
        }
                      
    }
}