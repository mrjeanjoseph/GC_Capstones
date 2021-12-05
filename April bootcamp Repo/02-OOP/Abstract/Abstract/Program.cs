using System;
using System.Collections.Generic;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            //cannot create instance of abstract class
            //Animal animal = new Animal();
            Pig pig = new Pig();
            pig.AnimalSound();
            pig.Eat();
            pig.Move();
            pig.Sleep();
            pig.Breath();
            animals.Add(pig);
            

            Dog dog = new Dog();
            dog.AnimalSound();
            dog.Eat();
            dog.Move();
            dog.Sleep();
            dog.Fetch();
            dog.Pet();
            dog.Breath();
            animals.Add(dog);
            
            foreach(Animal animal in animals)
            {
                animal.AnimalSound();
            }

            MoveAnimal(dog);
        }
        static void MoveAnimal(Animal animal)
        {
            animal.Move();
        }
    }
}
