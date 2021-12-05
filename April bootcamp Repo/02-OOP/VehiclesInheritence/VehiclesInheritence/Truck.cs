using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesInheritence
{
    class Truck : Car
    {
        //fields
        private double _carryWeight;
        //Properties
        public double CarryWeight
        {
            get { return this._carryWeight; }
            set { this._carryWeight = value; }
        }
        //Constructor
        public Truck(string name, int wheels, int maxSpeed, int seats, int doors, int windows, double carryWeight) : base(name, wheels, maxSpeed, seats, doors, windows)
        {
            this._carryWeight = carryWeight;
        }

        //Methods
        //Override
        public override void Drive()
        {
            Console.WriteLine("You step onto your truck's running board and get in");
            base.Drive();
        }

        public override void Stop()
        {
            base.Stop();//car's stop is fine
        }

        public override string ToString()
        {
            string result = base.ToString();
            return result + $"This truck has a carry weight of {this._carryWeight}";
        }

        //truck specific
        public void CarrySupplies(double supplyWeight)
        {
            if(supplyWeight > this._carryWeight)
            {
                Console.WriteLine("You cannot carry this much supplies.");
            }
            else
            {
                Console.WriteLine("You filled the truck with supplies.");
            }
        }
    }
}
