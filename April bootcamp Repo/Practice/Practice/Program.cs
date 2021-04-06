using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gets user info and displays it
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageF = int.Parse(age);
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine(ageF);
            Console.WriteLine(color);
        }
    }
}
