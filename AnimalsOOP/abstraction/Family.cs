﻿using System;
using test_test.abstraction;

namespace test_test
{
    public class AnimalFamily
    {

        public string FamilyName { get; set; }
        internal IShoutBehaviour shoutBehaviour {get;set;}
        public AnimalFamily() { }
        public AnimalFamily(string Name, IShoutBehaviour shoutBehaviour) {
            FamilyName = Name;
            this.shoutBehaviour = shoutBehaviour;
        }

        public void Leap(decimal distance)
        {
            throw new NotImplementedException();
        }

        public void Shout()
        {
            shoutBehaviour.Shout();
        }
    }
}