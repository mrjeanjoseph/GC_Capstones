using System;
using System.Collections.Generic;
using System.Text;

namespace TheOOPShop
{
    class Shop
    {
        //fields
        private string _name;
        private List<Item> _inventory;
        private double _salesTax = 1.06;
        //properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public List<Item> Inventory
        {
            get { return this._inventory; }
            set { this._inventory = value; }
        }
        //constructor
        public Shop(string name)
        {
            this._name = name;
            Restock();
        }
        //method
        private void Restock()//used to make constructor smaller
        {
            List<Item> temp = new List<Item>
            {
                new Item("Baja Blast",1.99),
                new Item("Coffee", 2.50),
                new Item("Skittles", 2.50),
                new Item("Big Red Gum", 0.99),
                new Item("Water Bottle", 2.99),
                new Item("Snickers", 0.99)
            };

            this._inventory = temp;
        }

        public void DisplayItems()
        {
            string formattedHeader = string.Format("{0,-15} | {1,6}", "Name", "Price");//format so its in a chart
            Console.WriteLine(formattedHeader);
            foreach (Item item in this._inventory)
            {
                string formattedDisplay = string.Format("{0,-15} | {1,6}", item.Name, item.Price);//format so its in a chart
                Console.WriteLine(formattedDisplay);
            }
        }

        public Item Buy(string itemName)
        {
            Item temp = null;

            //Search all items for a match
            foreach(Item item in this._inventory)
            {
                if(item.Name == itemName)
                {
                    temp = item;
                }
            }

            //if item is found
            if(temp != null)
            {
                Console.WriteLine("You bought the item");
            }
            else//if item not found
            {
                Console.WriteLine("That item isn't sold here.");
            }
            //returns either item or null
            return temp;
        }

        public void Greeting()
        {
            Console.WriteLine($"Welcome to {this._name}. How may I help you?");
        }

        public void DisplayCart(List<Item> cart)
        {
            Console.WriteLine("You purchased:");
            string formattedHeader = string.Format("{0,-15} | {1,6}", "Name", "Price");//format so its in a chart
            Console.WriteLine(formattedHeader);
            double total = 0;
            foreach (Item item in cart)
            {
                string formattedDisplay = string.Format("{0,-15} | {1,6}", item.Name, item.Price);//format so its in a chart
                Console.WriteLine(formattedDisplay);
                total += item.Price;
            }
            Console.WriteLine($"Your total is {total}");
            double totalTaxed = Math.Round(total * this._salesTax,2);//get tax
            Console.WriteLine($"Your total after tax is {totalTaxed}");
        }
    }
}
