using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Inheritence
{
    class Animal//Parent Class
    {
        private string _name;//no one has access to it
        protected string _dna;//only children have access
        public string Name//everyone has access
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public void Move()
        {
            Console.WriteLine("This animal has moved");
        }
        public virtual void Details()//virtual means children have the choice to override it
        {
            Console.WriteLine("This is a base animal. Nothing special");
        }
    }
}
