using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample
{
    class Triangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("This is a triangle");
        }
    }
}
