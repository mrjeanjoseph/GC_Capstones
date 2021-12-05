using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesInheritence
{
    class Car : Vehicle
    {
        //fields
        private int _seats;
        private int _doors;
        private int _windows;
        //Properties
        public int Seats
        {
            get { return this._seats; }
            set { this._seats = value; }
        }
        public int Doors
        {
            get { return this._doors; }
            set { this._doors = value; }
        }
        public int Windows
        {
            get { return this._windows; }
            set { this._windows = value; }
        }
        //Constructor. Sends back needed values to parent using base
        public Car(string name, int wheels, int maxSpeed, int seats, int doors, int windows) : base (name, wheels, maxSpeed)
        {
            this._seats = seats;
            this._doors = doors;
            this._windows = windows;
        }
        //methods
        //overriden 
        public override void Drive()
        {
            Console.WriteLine($"You entered through one of the {this._doors} doors and sat down in one of the {this._seats} seats.");
            Console.WriteLine($"You looked through one of the {this._windows} windows.");
            base.Drive();
        }
        public override void Stop()
        {
            Console.WriteLine("You brake to a stop and then put your car in Park.");
            base.Stop();
        }
        public override string ToString()
        {
            string result = base.ToString();
            return result + $"This Car has {this._seats} seats, {this._doors} doors and {this.Windows} windows.";
        }

    }
}
