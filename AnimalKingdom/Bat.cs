using System;

namespace AnimalKingdom
{
    public class Bat : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "cri!";
        }
        public int NumberOfNipples { get => 2; }
    }
}