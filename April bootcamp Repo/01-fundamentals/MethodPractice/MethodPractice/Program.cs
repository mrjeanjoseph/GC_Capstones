using System;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //handles all intro
            programIntro();

            //gets numbers
            double x = getInput();
            double y = getInput();

            Console.WriteLine(GetArea(x, y));
            Console.WriteLine(GetPerimeter(x, y));

            //Runs all math methods
            runProgram(x, y);
        }

        static void runProgram(double x, double y)
        {
            bool loopProgram = true;
            while (loopProgram)
            {


                int menuChoice;
                //Display menu options
                Console.WriteLine("Choice an option.");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                while (true)//get user choice for which calc they want to do
                {
                    menuChoice = int.Parse(Console.ReadLine());
                    if (menuChoice >= 1 && menuChoice <= 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a menu option.");
                    }
                }


                //Using display result to get a nicer display
                if (menuChoice == 1)//adding
                {
                    DisplayResult(Adder(x, y));
                }
                else if (menuChoice == 2)//subtracting
                {
                    DisplayResult(Subtract(x, y));
                }
                else if (menuChoice == 3)//multiplying
                {
                    DisplayResult(multiplyer(x, y));
                }
                else if (menuChoice == 4)//dividing
                {
                    DisplayResult(divider(x, y));
                }

                //No longer using WriteLine

                //Console.WriteLine(Adder(x, y));
                //Console.WriteLine(Subtract(x, y));
                //Console.WriteLine(multiplyer(x, y));
                //Console.WriteLine(divider(x, y));

                Console.WriteLine("Do you want to continue? y/n");
                while (true)
                {
                    string continueResult = Console.ReadLine();
                    if (continueResult == "y")
                    {
                        break;
                    }
                    else if (continueResult == "n")
                    {
                        loopProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input");
                    }
                }
            }
        }


        static void programIntro()//Runs all intro code. Gets name and age and displays. 
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age;
            while (true)
            {
                age = int.Parse(Console.ReadLine());//get age from user
                if(age <= 0)
                {
                    Console.WriteLine("Your age is too low. Please enter a age greater than 0.");
                }
                else//Correct input
                {
                    break;
                }
            }
            //Display user info

            Console.WriteLine(ReturnHelloUser(name, age));
        }

        //Get number from user
        static double getInput()
        {
            Console.WriteLine("Please enter a number.");
            double input = double.Parse(Console.ReadLine());//user input
            return input;//return back number 
        }
        //Method with 2 double parameters. returns a double
        static double Adder(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double multiplyer(double x, double y)
        {
            return x * y;
        }

        static double divider(double x, double y)
        {
            return x / y;
        }

        //Method overload for 2 parameters
        static string ReturnHelloUser(string user, int age)//Method to return formatted message
        {
            string greeting = $"Hello, {user}. You are {age} years old";
            return greeting;//end of method. No code past the return will run
        }
        //Method overload for 1 parameter
        static string ReturnHelloUser(string user)//Method to return formatted message
        {
            string greeting = $"Hello, {user}";
            return greeting;
        }
        //Method with no parameters
        static string ReturnHelloUser()
        {
            string greeting = $"Hello, user";
            return greeting;
        }

        static void DisplayResult(double result)
        {
            Console.WriteLine($"Your answer was {result}");
        }

        //Extra method practice. Not used in main program
        static double GetArea(double length, double width)
        {
            return length * width;
        }

        static double GetPerimeter(double length, double width)
        {
            return (length * 2) + (width * 2);
        }
    }
}
