using System;
using System.Collections.Generic;
using System.Text;

namespace Used_Car_Lot
{
    class UsedCar : Car
    {
        //fields
        private double _mileage;
        //property
        public double Mileage
        {
            get { return this._mileage; }
            set { this._mileage = value; }
        }
        //Constructor
        public UsedCar(string make, string model, int year, decimal price, double mileage):base (make,model,year,price)
        {
            this._mileage = mileage;
        }
        public UsedCar():base()
        {
            this._mileage = 0;
        }
        //methods
        public override string ToString()
        {
            return base.ToString() + $" (Used)\t{this.Mileage} miles";
        }
    }
}
