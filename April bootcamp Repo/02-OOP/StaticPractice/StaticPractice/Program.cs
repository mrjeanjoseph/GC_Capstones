using System;

namespace StaticPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int num = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (LogicValidation.StringNotEmpty(input))
                {
                    if (LogicValidation.StringIsNumeric(input))
                    {
                        num = int.Parse(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This is not a number");
                    }
                }
                else
                {
                    Console.WriteLine("That was an empty response");
                }

            }
            int min = 1;
            int max = 10;

            if(LogicValidation.AboveZero(num))
            {
                Console.WriteLine("That number was above zero");
            }
            else
            {
                Console.WriteLine("That number was under or equal to zero");
            }

            if(LogicValidation.AboveEqualZero(num))
            {
                Console.WriteLine("That number was above or equal to zero");
            }
            else
            {
                Console.WriteLine("That number was under zero");
            }

            if(LogicValidation.BetweenRange(num,min,max))
            {
                Console.WriteLine($"That number was between {min} and {max}");
            }
            else
            {
                Console.WriteLine($"That number was not between {min} and {max}");
            }
        }
    }
}
