using System;
using System.Collections.Generic;
using System.Text;

namespace Circles
{
    class Circle
    {
        private double _radius;//field
        public double Radius //property
        {
            get { return _radius; }
            set { this._radius = value; }
        }

        //constructor
        public Circle (double radius)
        {
            this._radius = radius;
        }

        //methods
        public double CalculateCircumference()
        {
            return 2 * Math.PI * this._radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(this._radius, 2);
        }

        public string CalculateFormattedCircumference()
        {
            double circ = CalculateCircumference();
            return FormatNumber(circ);
        }

        public string CalculateFormattedArea()
        {
            double area = CalculateArea();
            return FormatNumber(area);
        }

        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }

        //static method
        public static Circle getLarger(Circle x, Circle y)
        {
            if (x.Radius > y.Radius)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
