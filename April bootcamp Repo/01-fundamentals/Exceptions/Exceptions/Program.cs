using System;
using System.Text.RegularExpressions;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //catching formatexception
            double subtotal = 0.0;
            try
            {
                Console.WriteLine("Enter subtotal:");
                subtotal = double.Parse(Console.ReadLine());//Could break. Might throw formatexception
                if (subtotal < 0)//range checking
                {
                    throw new Exception("Cannot be Less than 0");//custom exception
                }
            }
            catch (FormatException e)//entered string instead of number
            {
                Console.WriteLine("Error! Invalid number.");
                Console.WriteLine(e);
            }
            catch (Exception e)//custom exception from range checking
            {
                //Console.WriteLine("How did you get here?");
                Console.WriteLine(e);
            }

            Console.WriteLine(subtotal);


            Console.WriteLine();
            //tryparse
            Console.WriteLine("Please enter a double.");
            string inputString = Console.ReadLine();
            double price; //If parsed, holds the value
            bool parseResult = double.TryParse(inputString, out price);//returns true if parsed. Returns false if not parsed
            if(parseResult == true)//parsed
            {
                Console.WriteLine($"that value is {price}");
            }
            else//not parsed
            {
                Console.WriteLine("That was not a double");
            }

            Console.WriteLine();
            //Regex Regular Expression
            string pattern = @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$";

            //"616-123-4567"
            if (Regex.IsMatch("fhdjakslhfskjdla", pattern))
            {
                Console.WriteLine("That was a phone number");
            }
            else
            {
                Console.WriteLine("That was not a phone number");
            }


            Console.WriteLine();
            //testing section
            //1. create basic program and test
            //2. cover logic errors (age is too low)
            //3. cover exceptions (try catch)
            //extra step with while loop
            while (true)
            {
                try
                {
                    Console.WriteLine("What is your age?");
                    int age = int.Parse(Console.ReadLine());
                    if (age < 0)
                    {
                        Console.WriteLine("Your age is too low.");
                    }
                    else
                    {
                        Console.WriteLine($"Your age is {age}");
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You did not enter an age.");
                }
            }
        }
    }
}
