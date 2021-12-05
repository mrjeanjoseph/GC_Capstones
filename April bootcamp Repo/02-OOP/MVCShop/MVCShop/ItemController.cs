using System;
using System.Collections.Generic;
using System.Text;

namespace MVCShop
{
    class ItemController
    {
        //field
        private List<Item> _items = new List<Item>
            {
                new Item("Stick", 1),
                new Item("Box", 5),
                new Item("Gucci Water", 50),
                new Item("Mac and Cheese", 10),
                new Item("Pills", 3)
            };
        private ItemView iView = new ItemView();

        //Constructor
        public ItemController()
        {

        }

        //methods
        public void RunShop()
        {
            DisplayMenu();
            Console.WriteLine("Which item would you like?");
            string input = Console.ReadLine();
            Item result = PurchaseItem(input);

            if (result == null)
            {
                Console.WriteLine("That item does not exist");
            }
            else
            {
                Console.WriteLine("You purchased:");
                iView.DisplayItemName(result);
            }
        }


        public void DisplayMenu()
        {
            iView.DisplayMenu(this._items);
        }

        public Item PurchaseItem(string name)
        {
            foreach(Item item in this._items)
            {
                if (item.Name.ToLower() == name.ToLower())
                {
                    return item;
                }
            }

            //not found
            return null;
        }

        public void AddItem(string name, double price)
        {
            Item newItem = new Item(name, price);
            this._items.Add(newItem);
        }
    }
}
