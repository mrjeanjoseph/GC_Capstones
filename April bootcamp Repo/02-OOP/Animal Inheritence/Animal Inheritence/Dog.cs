using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Inheritence
{
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barks all through out the night.");
            
        }
        public override void Details()
        {
            //Base uses parent's methods
            //base.Details();

            Console.WriteLine("This is a furry 4 legged animal. It is a very good dog.");
        }

        public override string ToString()
        {
            string result = $"Dog named: {Name}";
            return result;
        }
    }
}
