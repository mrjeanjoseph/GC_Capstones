using System;
using System.Collections.Generic;

namespace Debugging_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting up some variables to use in my program:

            bool addToppings = true; //declaring a bool that I will use to run a loop of adding toppings to a list
           
            List<string> availableToppings = new List<string>() // this is a list of available toppings on the pizza
            {
                "pepperoni",
                "olives",
                "Anchovies",
                "ham"
            };
            
            // Introduce the app to the user:

            Console.WriteLine("Time to order pizza!");

            List<string> toppings = new List<string>(); // declaring a new list that will hold the toppings that the customer is ordering

            
            
            // this loop is going to be running as long as my user still wants to add toppings to their pizza
            while (addToppings)
            {
                Console.WriteLine("Enter a pizza topping and I'll add it to your order: ");

                string userInput = Console.ReadLine(); // storing the user's input into a variable

                if (availableToppings.Contains(userInput))
                {
                    toppings.Add(userInput);

                }

                // this loop is going to run until the user enters a valid input, in this case, it's a y/n
                while (true)
                {
                    Console.WriteLine("Do you want to add another topping? y/n:");

                    string userResponse = Console.ReadLine();

                    if (userResponse == "y")
                    {
                        addToppings = true; // let's add more toppings! back to the beginning of the loop we go!
                        break;
                    }
                    if (userResponse == "n") 
                    {
                        addToppings = false; // done adding toppings, so we can set that loop to false and break out of this y/n validation loop
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, I didn't understand what you typed"); //user gets this message, and this loop starts over

                    }
                } 
            }

            Console.WriteLine("Ok great, so I have you down for a pizza with the following toppings:");

            foreach(string s in toppings) // this loop is displaying all the toppings that the user wants to have on their pizza
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("goodbye!");
        }
    }
}
