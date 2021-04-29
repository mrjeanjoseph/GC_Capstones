using System;
using System.Collections.Generic;
using System.Text;

namespace MVCShop
{
    //view
    class ItemView
    {

        public ItemView(Item item)
        {

        }

        //methods
        public void DisplayItem(Item item)
        {
            Console.WriteLine($"{item.Name} ${item.Price}");
        }

        public void DisplayMenu(List<Item> items)
        {
            Console.WriteLine("Name    Price");
            Console.WriteLine();

            foreach(Item item in items)
            {
                DisplayItem(item);
            }
        }

        public void DisplayItemName(Item item)
        {
            Console.WriteLine($"{item.Name}");
        }
    }
}
