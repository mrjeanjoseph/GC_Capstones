using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            do
            {
                //Getting 2 inputs
                Console.WriteLine("What is the first number you want to use?");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("What is the second number you want to use?");
                double y = double.Parse(Console.ReadLine());

                //Display menu
                Console.WriteLine("----------------");
                Console.WriteLine("Menu Options");
                Console.WriteLine("1: Add");
                Console.WriteLine("2: Subtract");
                Console.WriteLine("3: Multiply");
                Console.WriteLine("4: Divide");
                Console.WriteLine("----------------");

                //Get menu option
                int choice;
                while (true)
                {
                    //loop until we get 1-4
                    choice = int.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= 4)// Covers all numbers between 1-4
                    {
                        break;//Found right choice
                    }
                    else // all other options
                    {
                        Console.WriteLine("That was not a choice. Please choose a number between 1-4");
                    }
                }

                //menu options
                if (choice == 1) //add
                {
                    Console.WriteLine(x + y); // doing math directly in writeline
                }
                else if (choice == 2)//Sub
                {
                    Console.WriteLine(x - y);
                }
                else if (choice == 3)//multiply
                {
                    Console.WriteLine(x * y);
                }
                else if (choice == 4)//dividing
                {
                    Console.WriteLine(x / y);
                }

                //Ask user if they should continue
                Console.WriteLine("Do you want to continue? y/n");
                while (true)
                {
                    string loopCheck = Console.ReadLine();
                    if (loopCheck == "y")
                    {
                        break;//Continue prgram
                    } else if (loopCheck == "n")
                    {
                        runProgram = false;
                        break;//end program
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please type y/n");//Wrong choice
                    }
                }
            } while (runProgram);
            /*
             * Will run until the user chooses n.
             * Then runprogram becomes false and stops the loop.
             * If they choose y it continues back to the top
             */
        }
    }
}
