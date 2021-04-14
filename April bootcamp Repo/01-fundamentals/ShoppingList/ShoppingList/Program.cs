using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> items = new Dictionary<string, double>
            {
                {"chips",1.99 },
                {"candy", 0.99 },
                {"soda", 1.99 },
                {"water", 1.00 },
                {"juice", 2.99 },
                {"choco", 1.99 },
                {"tums", 3.99 },
                {"coffee", 2.50 }
            };

            //lists to hold order
            List<string> orderItem = new List<string>();
            List<double> orderPrice = new List<double>();

            Console.WriteLine("Welcome to the GC Gas station");
            //Display list of items
            Console.WriteLine("Item \tPrice");
            foreach(KeyValuePair<string, double> kvp in items)
            {
                Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
            }

            //ask for input
            while (true)
            {
                Console.WriteLine("Please choose an item to buy");
                string itemChoice = Console.ReadLine();
                double itemValue;

                if (items.TryGetValue(itemChoice, out itemValue))
                {
                    orderItem.Add(itemChoice);
                    orderPrice.Add(itemValue);
                    Console.WriteLine($"{itemChoice} was added to cart for ${itemValue}");

                    //ask if they want to keep adding items
                    bool addItems = true;
                    Console.WriteLine("Would you like to add more items? y/n");
                    while(true)//loop until they choose y/n
                    {
                        string addCheck = Console.ReadLine();
                        if(addCheck == "y")
                        {
                            break;//this break only affects this loop. Not the one around this
                        }
                        else if (addCheck == "n")
                        {
                            addItems = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was not a valid input.");
                        }
                    }

                    //either stops or continues loop
                    if(addItems == false)//stops loop
                    {
                        break;
                    }
                    //otherwise automatically loops

                }

                else//can't find item
                {
                    Console.WriteLine("That was not a correct choice. Please try again.");
                }

            }

            //displaying order info
            Console.WriteLine("Thank you for your order");
            Console.WriteLine("This was your order");
            //display order
            for(int i = 0; i < orderItem.Count; i++)
            {
                Console.WriteLine($"{orderItem[i]}\t{orderPrice[i]}");
            }

            double averagePrice = 0;
            foreach(double value in orderPrice)//add all values into averagePrice
            {
                averagePrice += value;
            }
            //get average using averagePrice and list.Count
            averagePrice = averagePrice / orderPrice.Count;
            averagePrice = Math.Round(averagePrice, 2);
            Console.WriteLine($"The average price of your items was ${averagePrice}");
        }
    }
}
