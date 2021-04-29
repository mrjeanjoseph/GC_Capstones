using System;
using System.Collections.Generic;
using System.Text;

namespace Mock_Assessment_3
{
    class Slacker : Villager
    {
        public Slacker()
        {
            Hunger = 3;
        }

        public override int Farm()
        {
            return 0;
        }
    }
}
