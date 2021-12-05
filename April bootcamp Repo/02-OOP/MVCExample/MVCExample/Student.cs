using System;
using System.Collections.Generic;
using System.Text;

namespace MVCExample
{
    class Student : Person
    {
        //fields
        private int _grade;
        //property
        public int Grade
        {
            get { return this._grade; }
            set { this._grade = value; }
        }
        //constructor
        public Student(string name, int age, int grade): base(name, age)
        {
            this._grade = grade;
        }
        //methods
        public override string ToString()
        {
            return base.ToString() + $" Student grade {this._grade}";
        }
    }
}
