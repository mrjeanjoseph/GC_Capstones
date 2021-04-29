using System;
using System.Collections.Generic;
using System.Text;

namespace MVCExample
{
    //Model
    class Person
    {
        //fields
        private string _name;
        private int _age;
        //properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }
        //constructor
        public Person(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
        //method
        public override string ToString()
        {
            return $"Person {this._name} age {this._age}";
        }
    }
}
