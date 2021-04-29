using System;
using System.Collections.Generic;
using System.Text;

namespace Mock_Assessment_3
{
    class Farmer : Villager
    {
        //constructor
        public Farmer()
        {
            Hunger = 1;
        }

        public override int Farm()
        {
            return 2;
        }
    }
}
