using System;
using System.Collections.Generic;

namespace StudentCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> hometowns = new Dictionary<string, string>
            {
                {"Sean" , "Plymouth"},
                {"Kalai", "Troy" },
                {"Jean", "Lascahobas" },
                {"Justin", "Wyoming" },
                {"Alice", "Detroit" },
                {"Jason", "Courtright" },
                {"Kristen", "Orange Park" },
                {"Kamesha", "Detriot" }
            };

            //Set up food here
            Dictionary<string, string> foods = new Dictionary<string, string>
            {
                {"Sean", "Pizza" },
                {"Kalai", "Dosa" },
                {"Jean", "Fritay" },
                {"Justin", "Baja Blast" },
                {"Alice", "Sushi" },
                {"Jason", "Mac and Cheese" },
                {"Kristen", "Mac and Cheese" },
                {"Kamesha", "Tacos" }
            };

            //Get name from user
            Console.WriteLine("Please enter a students name to get their info");
            //display list of name
            foreach(KeyValuePair<string,string> kvp in hometowns)
            {
                Console.WriteLine(kvp.Key); //displays names
            }
            string result = Console.ReadLine();

            //display info
            Console.WriteLine($"That student's hometown is {hometowns[result]}");
            //Set up display for food
            Console.WriteLine($"That student's favorite food is {foods[result]}");
        }
    }
}
