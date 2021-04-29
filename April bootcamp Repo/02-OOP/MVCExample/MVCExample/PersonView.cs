using System;
using System.Collections.Generic;
using System.Text;

namespace MVCExample
{
    //view
    class PersonView
    {
        public PersonView()
        {

        }
        //methods
        public void DisplayPerson(Person person)
        {
            Console.WriteLine(person.ToString());
        }

        public void DisplayAll(List<Person> people)
        {
            foreach(Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
