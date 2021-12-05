using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayLists
            ArrayList numbers = new ArrayList();
            numbers.Add(5);
            numbers.Insert(0, 9);//inserts a value at the index marked
            numbers.Remove(5);//removes first instance of the value
            numbers.RemoveAt(0);//removes the index supplied
            
            //Can add all data types within arraylists even if it causes errors
            //numbers.Add("Hello");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"There are currently {numbers.Count} elements in the arraylist.");


            //create array list
            //add 5-10 numbers
            //create a result variable
            //use a foreach loop to add them all together into the result variable
            //display the result in the console
            ArrayList values = new ArrayList();
            values.Add(1);
            values.Add(2);
            values.Add(3);
            values.Add(4);
            values.Add(5);
            int result = 0;
            foreach (int i in values)
            {
                result += i;
            }
            Console.WriteLine($"The values added together is {result}");

            Console.WriteLine();
            //Hashtables
            Hashtable ht = new Hashtable();
            ht.Add("001", "John");
            ht.Add("002", "Paul");
            //Can add all datatypes even if it causes an error
            //ht.Add(2, true);
            Console.WriteLine(ht["001"]);

            Console.WriteLine();
            //Lists

            //blank list
            //List<int> numList = new List<int>();

            //adding multiple objects when creating a list
            List<int> numList = new List<int>
            {
                1,
                2,
                3,
                4
            };

            numList.Add(5);
            numList.Insert(0, 9);
            //numList.Remove(5);
            //numList.RemoveAt(0);
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"There are {numList.Count} elements in the List");
            numList[0] = 1;//can access any index like you would with an array
            int numResult = numList[0];

            Console.WriteLine();
            //Dictionary
            Dictionary<string, bool> tasty = new Dictionary<string, bool>();
            tasty.Add("Chicken Curry", true);
            tasty.Add("Asparagus", false);

            Console.WriteLine(tasty["Chicken Curry"]);
            Console.WriteLine(tasty["Asparagus"]);

            //How to use user input to get value
            Console.WriteLine("Which food would you like to check?");
            string input = Console.ReadLine();
            bool resultTasty = tasty[input];
            Console.WriteLine(resultTasty);

            bool foodTest;
            if (tasty.TryGetValue("Doritos",out foodTest))
            {
                Console.WriteLine($"Could find key. Here is value: {foodTest} ");
            }
            else
            {
                Console.WriteLine("Could not find key");
            }

            //how to loop through dictionary
            foreach(KeyValuePair<string, bool> kvp in tasty)
            {
                //How to access key and value in foreach
                //Console.WriteLine(kvp.Key);
                //Console.WriteLine(kvp.Value);

                if(kvp.Value == true)
                {
                    Console.WriteLine($"{kvp.Key} is tasty!");
                    
                }
                else
                {
                    Console.WriteLine($"{kvp.Key} is icky!");
                }
            }
        }
    }
}
