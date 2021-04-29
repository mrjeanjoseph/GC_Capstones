using System;
using System.Collections.Generic;

namespace MVCShop
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemController iController = new ItemController();
            iController.RunShop();
        }
    }
}
