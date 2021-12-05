using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesInheritence
{
    class Skateboard : Vehicle
    {
        //fields
        private string _design;
        //properties
        public string Design
        {
            get { return this._design; }
            set { this._design = value; }
        }
        //Constructor
        public Skateboard(string name, int wheels, int maxSpeed, string design) : base(name, wheels, maxSpeed)
        {
            this._design = design;

        }
        //Methods
        //Overrides
        public override void Drive()
        {
            Console.WriteLine("They hop on the skateboard and kick forward.");
            base.Drive();
        }
        public override void Stop()
        {
            Console.WriteLine("They jump off the board and grab it.");
            base.Stop();
        }
        public override string ToString()
        {
            string result = base.ToString();
            return result + $"This skateboard has a {this._design} design.";
        }
        //Specific to Skateboard
        public void Trick()
        {
            Console.WriteLine("While on the skateboard, you do a kickflip.");
        }
    }
}
