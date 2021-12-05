using System;

namespace Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            runProgram();
        }

        //main program
        static void runProgram()
        {
            bool loopProgram = true;
            while (loopProgram)
            {
                int value = getInput();
                //Column headers. Formated to match the number display
                Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10}", "Number", "Squared", "Cubed"));
                Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10}", "--------", "--------", "--------"));
                for (int i = 1; i <= value; i++)
                {
                    //Column values. Formated right align and given 10 spaces to work with
                    Console.WriteLine(string.Format("{0,10} | {1,10} | {2,10}",i, square(i), cube(i)));
                }

                Console.WriteLine("Do you want to continue? y/n");
                while (true)
                {
                    string choice = Console.ReadLine();
                    if (choice.ToLower().Trim() == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (choice.ToLower().Trim() == "n")
                    {
                        loopProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid input");
                    }
                }
            }
        }

        //gets user input
        static int getInput()
        {
            int result;
            Console.WriteLine("Enter a number between 1 and 1290.");
            while (true)
            {
                result = int.Parse(Console.ReadLine());
                if (result <= 0)//Doesn't work with any number less than 1
                {
                    Console.WriteLine("You did not enter a value 1 or greater.");
                }
                else if (result > 1290)//when cubed, any value past this overflows to negative
                {
                    Console.WriteLine("This value is too large.");
                }
                else//found a number above 1
                {
                    break;
                }
            }
            return result;
        }
        //Takes in input, then squares it
        static int square(int value)
        {
            return value * value;
        }
        //Take in input, then cube it
        static int cube(int value)
        {
            return value * value * value;
        }
    }
}
