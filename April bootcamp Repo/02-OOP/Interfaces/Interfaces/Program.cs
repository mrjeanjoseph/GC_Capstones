using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            Pig pig = new Pig();
            pig.AnimalSound();
            pig.Eat();
            pig.Move();
            pig.Sleep();
            pig.Birth();
            pig.Hair();
            pig.WarmBlooded();
            animals.Add(pig);
            

            Dog dog = new Dog();
            dog.AnimalSound();
            dog.Eat();
            dog.Move();
            dog.Sleep();
            dog.Birth();
            dog.Hair();
            dog.WarmBlooded();
            dog.Pet();
            dog.Fetch();

            animals.Add(dog);

            foreach(IAnimal animal in animals)
            {
                animal.AnimalSound();
            }
            MoveAnimal(dog);
        }
        static void MoveAnimal(IAnimal animal)
        {
            animal.Move();
        }
    }
}
