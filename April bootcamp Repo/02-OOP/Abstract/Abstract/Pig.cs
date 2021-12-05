using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Oink");
        }

        public override void Eat()
        {
            Console.WriteLine("The pig starts eating trash");
        }

        public override void Move()
        {
            Console.WriteLine("The pig moves to a mud pile");
        }

        public override void Sleep()
        {
            Console.WriteLine("The pig lays on its side and sleeps");
        }
    }
}
