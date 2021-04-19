using System;
using System.Collections.Generic;
using System.Text;

namespace Circles
{
    class Validator
    {
        public static bool ValidateCircumference(Circle x, double radius)
        {
            double Circumference = 2 * Math.PI * radius;
            double circleCircumference = x.CalculateCircumference();
            if (Circumference == circleCircumference)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateArea(Circle x, double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            double circleArea = x.CalculateArea();
            if(area == circleArea)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
