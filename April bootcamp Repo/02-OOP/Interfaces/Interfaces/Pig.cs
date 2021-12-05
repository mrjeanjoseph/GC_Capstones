using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Pig : IAnimal, IMammal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Oink");
        }

        public void Birth()
        {
            Console.WriteLine("This pig gave birth to a baby Pig. Congrats!");
        }

        public void Eat()
        {
            Console.WriteLine("They eat trash");
        }

        public void Hair()
        {
            Console.WriteLine("This pig has barely any hair");
        }

        public void Move()
        {
            Console.WriteLine("Walks to mud pile");
        }

        public void Sleep()
        {
            Console.WriteLine("The pig rests on its side and sleeps");
        }

        public void WarmBlooded()
        {
            Console.WriteLine("This pig has the ability to warm itself");
        }
    }
}
