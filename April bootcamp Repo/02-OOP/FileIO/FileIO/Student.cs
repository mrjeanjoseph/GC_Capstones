using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO
{
    class Student
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
        //Constructor
        public Student(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public override string ToString()
        {
            return $"Student {this._name} is {this._age} years old";
        }

    }
}
