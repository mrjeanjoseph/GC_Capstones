using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Animal
    {
        
        public abstract void Move();
        public abstract void Sleep();
        public abstract void Eat();
        public abstract void AnimalSound();
        public void Breath()
        {
            Console.WriteLine("This animal takes a breath");
        }
    }
}
