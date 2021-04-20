using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesInheritence
{
    class Vehicle//Parent
    {
        //fields
        private string _name;
        private int _wheels;
        private int _maxSpeed;
        //properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public int Wheels
        {
            get { return this._wheels; }
            set { this._wheels = value; }
        }
        public int MaxSpeed
        {
            get { return this._maxSpeed; }
            set { this._maxSpeed = value; }
        }
        //Constuctor
        public Vehicle(string name, int wheels, int maxSpeed)
        {
            this._name = name;
            this._wheels = wheels;
            this._maxSpeed = maxSpeed;
        }
        //Methods
        //Virtual
        public virtual void Drive()
        {
            Console.WriteLine($"The vehicle {this._name} has started to drive. It drove at a max speed of {this._maxSpeed}.");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The vehicle {this._name} has stopped.");
        }
        //override toString
        public override string ToString()
        {
            return $"Vehicle named {this._name} has {this._wheels} wheels and has a max speed of {this._maxSpeed}.";
        }
    }
}
