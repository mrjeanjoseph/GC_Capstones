using System;
using System.Collections.Generic;
using System.Text;

namespace MVCExample
{
    //Controller
    class PersonController
    {
        //field
        private List<Person> _people = new List<Person>
        {
            new Person("Justin",23),
            new Person("Kristen", 18),
            new Person("Tommy", 156),
            new Person("Kamesha", 21),
            new Student("Josh", 15, 9)
        };

        //field for views. Controller will handle so no property
        private PersonView pView = new PersonView(); 

        //property (not always needed)
        public List<Person> People
        {
            get { return this._people; }
            set { this._people = value; }
        }

        //Methods
        public void DisplayPerson(string name)
        {
            foreach(Person person in this._people)
            {
                if (person.Name == name)
                {
                    pView.DisplayPerson(person);
                }
            }
        }

        public void DisplayAll()
        {
            pView.DisplayAll(this._people);
        }

        public void AddPerson(string name, int age)
        {
            Person newPerson = new Person(name, age);
            this._people.Add(newPerson);
        }

        public void AddStudent(string name, int age, int grade)
        {
            Student newStudent = new Student(name, age, grade);
            this._people.Add(newStudent);
        }

        public void EditPerson(string searchName, string newName, int newAge)
        {
            for(int i = 0; i < this._people.Count; i++)
            {
                if(this._people[i].Name == searchName)
                {
                    this._people[i].Name = newName;
                    this._people[i].Age = newAge;
                }
            }
        }

        public void DeletePerson(string name)
        {
            for(int i = 0; i< this._people.Count; i++)
            {
                if(this._people[i].Name == name)
                {
                    this._people.RemoveAt(i);
                    //to avoid potential loop issues. get out early
                    break;
                }
            }
        }
    }
}
