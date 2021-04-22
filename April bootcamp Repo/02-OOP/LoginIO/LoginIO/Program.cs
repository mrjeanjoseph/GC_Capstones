using System;
using System.Collections.Generic;
using System.IO;

namespace LoginIO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = ReadAndCreateList();
            DisplayUsers(users);
            string result = getInputForDetails();
            getDetails(result,users);
            bool userChoice = askCreateUser();
            if (userChoice == true)
            {
                users = CreateUser(users);
                Console.WriteLine("List updated");
                DisplayUsers(users);
            }
            UpdateList(users);
        }

        static void UpdateList(List<User> users)
        {
            StreamWriter writer = new StreamWriter("Users.txt");
            foreach(User user in users)
            {
                writer.WriteLine($"{user.Name},{user.Pass}");
            }
            writer.Close();
        }

        static List<User> CreateUser(List<User> users)
        {
            Console.WriteLine("Please enter a username");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a password");
            string pass = Console.ReadLine();
            User user = new User(name, pass);
            users.Add(user);
            return users;
        }

        static bool askCreateUser()
        {
            Console.WriteLine("Do you want to create a user? y/n");
            string result = Console.ReadLine();
            if (result == "y")
            {
                return true;
            }
            else if (result == "n")
            {
                return false;
            }
            else
            {
                //lazy
                //to finish, loop until y/n
                return false;
            }
        }

        static string getInputForDetails()
        {
            Console.WriteLine("Please enter a username to get their details.");
            string result = Console.ReadLine();

            return result;
        }

        static void getDetails(string name, List<User> users)
        {
            foreach(User user in users)
            {
                if(user.Name == name)
                {
                    Console.WriteLine(user.ToString());
                }
            }
        }

        static void DisplayUsers(List<User> users)
        {
            Console.WriteLine("These are your Users.");
            Console.WriteLine("--------------------------");
           foreach(User user in users)
            {
                Console.WriteLine(user.Name);
            }
        }

        static List<User> ReadAndCreateList()
        {
            StreamReader reader = new StreamReader("Users.txt");
            List<User> users = new List<User>();
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                else
                {
                    //Commented out writelines to clean console
                    //Console.WriteLine(line);
                    string[] splitLine = line.Split(",");
                    //Console.WriteLine(splitLine[0]);
                    //Console.WriteLine(splitLine[1]);

                    User user = new User(splitLine[0], splitLine[1]);
                    users.Add(user);
                }
            }

            reader.Close();

            return users;
        }
    }
}
