using System;
using System.Collections.Generic;
using System.Text;

namespace MVCShop
{
    //Model
    class Item
    {
        //fields
        private string _name;
        private double _price;
        //properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public double Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        //Constructor
        public Item (string name, double price)
        {
            this._name = name;
            this._price = price;
        }
    }
}
