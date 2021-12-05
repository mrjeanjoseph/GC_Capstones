using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Dog : Animal
    {
        

        public override void AnimalSound()
        {
            Console.WriteLine("Bark");
        }
        public override void Eat()
        {
            Console.WriteLine("The dog eats Kibble.");
        }
        public override void Move()
        {
            Console.WriteLine("The dog runs away his leash");
        }
        public override void Sleep()
        {
            Console.WriteLine("The dog sleeps in the sun");
        }
        //dog specific
        public void Fetch()
        {
            Console.WriteLine("The dog chases after a stick");
        }
        public void Pet()
        {
            Console.WriteLine("The dog gets pet. It is a very good dog.");
        }
    }
}
