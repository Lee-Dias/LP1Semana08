﻿using System;

namespace AnimalKingdom
{
    public class Dog : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
        public int NumberOfNipples { get => 8; }
    }
}
