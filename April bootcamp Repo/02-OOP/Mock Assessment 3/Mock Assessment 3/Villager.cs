using System;
using System.Collections.Generic;
using System.Text;

namespace Mock_Assessment_3
{
    abstract class Villager
    {
        //field
        private int _hunger;
        //property
        public int Hunger
        {
            get { return this._hunger; }
            set { this._hunger = value; }
        }
        //Methods
        abstract public int Farm();
    }
}
