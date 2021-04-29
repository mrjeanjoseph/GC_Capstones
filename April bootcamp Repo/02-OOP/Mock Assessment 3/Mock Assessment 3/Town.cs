using System;
using System.Collections.Generic;
using System.Text;

namespace Mock_Assessment_3
{
    class Town
    {
        //field
        private List<Villager> _villagers = new List<Villager>();
        //property
        public List<Villager> Villagers
        {
            get { return this._villagers; }
            set { this._villagers = value; }
        }
        //Constructor
        public Town()
        {
            this._villagers.Add(new Farmer());
            this._villagers.Add(new Slacker());
            this._villagers.Add(new Slacker());
            this._villagers.Add(new Slacker());
        }
        //Methods
        public int Harvest()
        {
            int total = 0;
            foreach(Villager villager in this._villagers)
            {
                total += villager.Farm();
            }
            return total;
        }

        public int CalcFoodConsumption()
        {
            int total = 0;
            foreach(Villager villager in this._villagers)
            {
                total += villager.Hunger;
            }
            return total;
        }

        public bool SurviveTheWinter()
        {
            int food = Harvest();
            int hunger = CalcFoodConsumption();
            if (food >= hunger)
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
