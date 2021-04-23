﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Used_Car_Lot
{
    class Car
    {
        //fields
        private string _make;
        private string _model;
        private int _year;
        private decimal _price;
        //properties
        public string Make
        {
            get { return this._make; }
            set { this._make = value; }
        }
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }
        public int Year
        {
            get { return this._year; }
            set { this._year = value; }
        }
        public decimal Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        //Constructor
        public Car(string make, string model, int year, decimal price)
        {
            this._make = make;
            this._model = model;
            this._year = year;
            this._price = price;
        }
        public Car()
        {
            this._make = "";
            this._model = "";
            this._year = 0;
            this._price = 0;
        }
        //override
        public override string ToString()
        {
            return $"{this._make}\t{this._model}\t{this._year}\t${this._price}";
        }
    }
}
