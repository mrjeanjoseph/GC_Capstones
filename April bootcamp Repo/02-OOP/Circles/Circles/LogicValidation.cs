using System;
using System.Collections.Generic;
using System.Text;

namespace StaticPractice
{
    class LogicValidation
    {
        public static bool AboveZero(int x)
        {
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AboveEqualZero(int x)
        {
            if(x >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool BetweenRange(int value, int min, int max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool StringNotEmpty(string value)
        {
            if(value == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool StringIsNumeric(string value)
        {
            try
            {
                int x = int.Parse(value);
                return true;
            }
            catch(Exception e)  {
                return false;
            }
        }
    }
}
