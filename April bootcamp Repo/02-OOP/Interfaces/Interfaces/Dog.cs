using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Dog : IAnimal, IMammal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Woof");
        }

        public void Birth()
        {
            Console.WriteLine("This dog gave birth to a very good puppy");
        }

        public void Eat()
        {
            Console.WriteLine("This dog is eating some chicken");
        }

        public void Hair()
        {
            Console.WriteLine("This dog has a beautiful coat of fur");
        }

        public void Move()
        {
            Console.WriteLine("This dog chases a car");
        }

        public void Sleep()
        {
            Console.WriteLine("This dog sleeps in an uncomfortable position for hours");
        }

        public void WarmBlooded()
        {
            Console.WriteLine("This dog warms itself up as it jumps in the snow");
        }

        //dog specific methods
        public void Fetch()
        {
            Console.WriteLine("This dog chases after a stick.");
        }
        
        public void Pet()
        {
            Console.WriteLine("The dog gets all of the pets.");
        }
    }
}
