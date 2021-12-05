using System;

namespace Room_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            bool loop = true;
            do
            {
                //Get input from users
                Console.WriteLine("Enter length: ");
                string input = Console.ReadLine();
                double length = double.Parse(input);

                Console.WriteLine("Enter width: ");
                input = Console.ReadLine();
                double width = double.Parse(input);

                //calculations
                double area = length * width;
                double perimeter = (length * 2) + (width * 2);
                double carpet = area / 5;
                double paint = perimeter / 5;

                //display
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Carpet Tiles: {carpet}");
                Console.WriteLine($"Paint: {paint}");

                //continue?
                Console.WriteLine("Do you want to continue? y/n");
                while (true)
                {
                    string checkLoop = Console.ReadLine();
                    if (checkLoop == "n")
                    {
                        loop = false;
                        break;
                    } else if (checkLoop == "y")
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("That was not y/n. Try again");
                    }
                }
                
            } while (loop);
        }
    }
}
