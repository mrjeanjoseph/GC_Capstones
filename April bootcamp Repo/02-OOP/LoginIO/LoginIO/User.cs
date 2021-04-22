using System;
using System.Collections.Generic;
using System.Text;

namespace LoginIO
{
    class User
    {
        //fields
        private string _name;
        private string _pass;
        //properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Pass
        {
            get { return this._pass; }
            set { this._pass = value; }
        }
        //Constructor
        public User (string name, string pass)
        {
            this._name = name;
            this._pass = pass;
        }
        //methods
        public override string ToString()
        {
            return $"User name:{this._name} pass:{this.Pass}";
        }
    }
}
