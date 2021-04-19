using StaticPractice;
using System;
using System.Collections.Generic;

namespace Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing all methods
            //Circle myCircle = new Circle(5);
            //Circle myCircle2 = new Circle(6);
            //Console.WriteLine(circle.CalculateCircumference());
            //Console.WriteLine(circle.CalculateArea());
            //Console.WriteLine(circle.CalculateFormattedCircumference());
            //Console.WriteLine(circle.CalculateFormattedArea());

            //static method test. getLarger
            //Circle larger = Circle.getLarger(myCircle, myCircle2);
            //Console.WriteLine(larger.Radius);

            //int valueTest = 5;
            //Circle circleTest = new Circle(5);
            //Console.WriteLine(Validator.ValidateCircumference(circleTest, valueTest));
            //Console.WriteLine(Validator.ValidateArea(circleTest, valueTest));
            

            

            bool runProgram = true;
            int counter = 0;
            List<Circle> circleList = new List<Circle>();
            while (runProgram)
            {
                Console.WriteLine("Please enter a radius for a circle.");
                double input = 0;
                while (true)//loop until valid
                {
                    try
                    {
                        input = double.Parse(Console.ReadLine());
                        if (input <= 0)//too small
                        {
                            Console.WriteLine("That number was too small");
                        }
                        else//correct
                        {
                            break;
                        }
                    }
                    catch (Exception e)//not a number
                    {
                        Console.WriteLine("That was not a number.");
                    }
                }

                Circle circle = new Circle(input);
                counter++;
                circleList.Add(circle);

                Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
                Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");

                Console.WriteLine("Would you like to make another circle? y/n");
                while(true)
                {
                    string result = Console.ReadLine();
                    if (result.ToLower() == "y")
                    {
                        break; 
                    }
                    else if (result.ToLower() == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not y/n");
                    }
                }
            }

            Console.WriteLine($"Goodbye. You created {counter} circles");
            Console.WriteLine($"Goodbye. You created {circleList.Count} circles");
        }
    }
}
