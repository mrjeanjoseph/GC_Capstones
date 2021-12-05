using System;
using System.Collections.Generic;

namespace TheOOPShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop OOPShop = new Shop("OOP Shop");
            List<Item> cart = new List<Item>();
            OOPShop.Greeting();

            bool runProgram = true;
            while(runProgram)
            {
                OOPShop.DisplayItems();

                Console.WriteLine("What would you like to buy?");
                while(true)//handle item buying
                {
                    string result = Console.ReadLine();
                    Item itemResult = OOPShop.Buy(result);
                    if (itemResult != null)//if an item returns, we are good. if null, it loops again
                    {
                        cart.Add(itemResult);
                        break;
                    }
                }

                Console.WriteLine("Would you like to buy more? y/n");
                while(true)//continueing
                {
                    string result = Console.ReadLine();
                    if(result =="y")
                    {
                        break;
                    }
                    else if (result == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid choice");
                    }
                }
                Console.Clear();
            }

            //Finished. Display cart info
            OOPShop.DisplayCart(cart);

        }
    }
}
