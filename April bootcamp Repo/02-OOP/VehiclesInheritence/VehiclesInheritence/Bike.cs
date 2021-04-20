using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesInheritence
{
    class Bike : Vehicle
    {
        //fields
        private bool _trainingWheel;
        //properties
        public bool TrainingWheel
        {
            get { return this._trainingWheel; }
            set { this._trainingWheel = value; }
        }
        //Constructor
        public Bike(string name, int wheels, int maxSpeed, bool trainingWheel) : base(name, wheels, maxSpeed)
        {
            this._trainingWheel = trainingWheel;
            
        }
        //Methods
        //Overrides
        public override void Drive()
        {
            Console.WriteLine("They removed their kick stand and got on their bike.");
            base.Drive();
        }
        public override void Stop()
        {
            Console.WriteLine("They used their brakes to stop and then put down the kick stand.");
            base.Stop();
        }
        public override string ToString()
        {
            string result = base.ToString();
            return result + $"Does this bike have a training wheel? {this._trainingWheel}";
        }
    }
}
