using System;

namespace ConsoleClearDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console Clear demo!");

            Console.WriteLine("Tell me your name:");

            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");

            Console.WriteLine("What is your password?");

            string password = Console.ReadLine();
            
            ConsoleClear();

            Console.WriteLine($"Oh, I see your password is {password} ");

            Console.WriteLine("Ok, see ya!");
        }

        public static void ConsoleClear()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
