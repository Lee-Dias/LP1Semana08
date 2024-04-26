using System;

namespace AnimalKingdom
{
    public class Bee : Animal , ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "bee!";
        }
        public int NumberOfWings     { get => 4; }
    }
}