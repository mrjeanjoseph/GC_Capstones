using System;
using System.Collections.Generic;

namespace Animal_Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            //base parent child
            Animal animal = new Animal();
            animal.Move();
            animal.Name = "Base";
            Dog dog = new Dog();
            dog.Move();
            dog.Bark();
            dog.Name = "Child";

            //testing virtual/override
            animal.Details();
            dog.Details();
            Console.WriteLine(dog.ToString());


            //polymorphism
            PrintDetails(animal);
            PrintDetails(dog);
            List<Animal> animals = new List<Animal>();
            animals.Add(animal);
            animals.Add(dog);
            animals[0].Details();
            animals[1].Details();
        }

        static void PrintDetails(Animal animal)
        {
            animal.Details();
        }
    }
}
