using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            checkFile();

            List<Student> classroom = new List<Student>();

            classroom = readAndSave(classroom);

            Display(classroom);

            classroom = Menu(classroom);

            SaveClassroomToFile(classroom);
        }

        static void checkFile()
        {
            //check if file exists
            if (File.Exists("People.txt"))
            {
                Console.WriteLine("We have a classroom set up");
            }
            else
            {
                //REMINDER. SET UP DEFAULT CLASSROOM
                StreamWriter classWriter = new StreamWriter("People.txt");
                classWriter.WriteLine("Justin,16");
                classWriter.WriteLine("Kristen,16");
                classWriter.WriteLine("Tommy,2065");
                classWriter.Close();
            }
        }

        static List<Student> readAndSave(List<Student> classroom)
        {
            //read file and save info in an object
            StreamReader reader = new StreamReader("People.txt");
            while (true)
            {
                //read each line
                string line = reader.ReadLine();
                if (line == null)//if line is empty, stop
                {
                    break;
                }
                else
                {
                    string[] splitLine = line.Split(",");//split by comma. (name,age)
                    string name = splitLine[0];//storing name and age
                    int age = 0;
                    try//should be an int
                    {
                        age = int.Parse(splitLine[1]);
                    }
                    catch (Exception e)//if the file is not set up correctly
                    {
                        //stop program method

                        //Console.WriteLine("This file is not set up correctly. Please double check your file.");
                        //System.Environment.Exit(1);

                        //default value method

                        Console.WriteLine($"{name} is not set up correctly. They have been given an age of 0. Please fix the file.");
                        age = 0;
                    }
                    //save student in list
                    Student student = new Student(name, age);
                    classroom.Add(student);
                }
            }
            //We've gotten all students
            //ALWAYS CLOSE YOUR READER AND WRITERS
            reader.Close();
            return classroom;
        }

        static void SaveClassroomToFile(List<Student> classroom)
        {
            StreamWriter writer = new StreamWriter("People.txt");
            foreach (Student student in classroom)
            {
                string output = $"{student.Name},{student.Age}";
                writer.WriteLine(output);
            }
            writer.Close();
        }

        static List<Student> AddStudent(List<Student> classroom)
        {
            Console.WriteLine("What is the name of the student?");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("What is their age?");
            int age = 0;
            while (true)
            {
                try
                {
                    age = int.Parse(Console.ReadLine());
                    if (age > 0)//only want ages above 0
                    {
                        break;
                    }
                    else//too small of a number
                    {
                        Console.WriteLine("That was too young. Please enter a larger number");
                    }
                }
                catch (Exception e)//entered a string
                {
                    Console.WriteLine("That was not a number");
                }
            }
            //creating student
            Student student = new Student(name, age);
            classroom.Add(student);
            return classroom;
        }

        static List<Student> RemoveStudent(List<Student> classroom)
        {
            Console.WriteLine("Which student would you like to remove?");
            string removeName = Console.ReadLine();
            bool studentFound = false;
            foreach (Student student in classroom)
            {
                if (removeName.ToLower().Trim() == student.Name.ToLower().Trim())
                {
                    studentFound = true;
                    classroom.Remove(student);
                    Console.WriteLine("That student was removed");
                    break;
                }
            }

            if (studentFound == false)
            {
                Console.WriteLine("That student is not in the class");
            }

            return classroom;
        }

        static List<Student> Menu(List<Student> classroom)
        {
            //display choices
            while (true)
            {
                Console.WriteLine("Would you like to add a student, remove one or quit? add/remove/quit");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "add")
                {
                    classroom = AddStudent(classroom);
                }
                else if (choice == "remove")
                {
                    classroom = RemoveStudent(classroom);
                }
                else if (choice == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("that was not add/quit. Try again");
                }
            }
            //outside of menu loop

            return classroom;
        }

        static void Display(List<Student> classroom)
        {
            Console.WriteLine("This is your classroom.");
            Console.WriteLine();
            // displaying all students in list
            foreach (Student student in classroom)
            {
                Console.WriteLine(student.ToString());
            }
        }

        

        static void Tester()
        {

            if(File.Exists("People.txt"))
            {
                Console.WriteLine("This file exists");
            }
            else
            {
                Console.WriteLine("This file does not exist.");
            }


            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            //Testing writer
            //cerating people.txt
            //StreamWriter writer = new StreamWriter("People.txt");
            StreamWriter writer = File.AppendText("People.txt");
            //writer.Write("Word ");
            writer.WriteLine("word 2");
            writer.WriteLine("Line");
            //write user input to the file
            writer.WriteLine(input);
            writer.Close();

            StreamReader reader = new StreamReader("People.txt");
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
