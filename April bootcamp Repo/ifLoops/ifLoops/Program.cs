using System;

namespace ifLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance;
            double cost;
            int quanity;
            bool runProgram=true;
            do
            {
                while (true)
                {
                    Console.WriteLine("What is your balance?");
                    balance = double.Parse(Console.ReadLine());
                    if (balance <= 0)
                    {
                        Console.WriteLine("Your balance is too low");
                    }
                    else
                    {
                        break;
                    }
                }


                do
                {
                    Console.WriteLine("How much is your item?");
                    cost = double.Parse(Console.ReadLine());
                    if (cost <= 0)
                    {
                        Console.WriteLine("Your item is not free");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                bool quanityCheck = true;
                do
                {
                    Console.WriteLine("How many are you buying?");
                    quanity = int.Parse(Console.ReadLine());
                    if (quanity <= 0)
                    {
                        Console.WriteLine("Why are you buying 0 items?");
                    }
                    else
                    {
                        quanityCheck = false;
                    }
                } while (quanityCheck);


                for (int i = 0; i < quanity; i++)
                {
                    balance -= cost;
                }

                Console.WriteLine($"You have {balance} left over.");

                if (balance < 0)
                {
                    Console.WriteLine("You bought too many items");
                }

                Console.WriteLine("Do you want to continue? y/n");
                while (true)
                {
                    string result = Console.ReadLine();
                    if(result == "y")
                    {
                        break;
                    }
                    else if (result == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a y/n");
                    }
                }

            } while (runProgram);
            //bool inputCheck = true;
            //int count;
            //Console.WriteLine("How many times do you want to loop?");
            //do
            //{
            //    count = int.Parse(Console.ReadLine());
            //    if (count > 0)
            //    {
            //        Console.WriteLine("This number works");
            //        inputCheck = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("This number is too small.");
            //    }
            //} while (inputCheck);
            



            //for (int i = 1; i <= count; i++)
            //{
            //    //Console.WriteLine(i);
            //    if (i > 10)
            //    {
            //        Console.WriteLine("This is a big number");
            //    }

            //    if (i > 5)
            //    {
            //        Console.WriteLine("Above 5");
            //    } else if (i == 5)
            //    {
            //        Console.WriteLine("Equal to 5");
            //    } 
            //    else
            //    {
            //        Console.WriteLine("Under 5");
            //    }
            //}
            //int[] x = { 1, 900, 3 };

            //foreach (int item in x)
            //{
            //    Console.WriteLine(item);
            //}

            ////int counter = 0;
            ////bool loop = true;
            ////int ClassSize = 100;
            ////string result = "";

            ////for (int i = 0; i < ClassSize; i++)
            ////{
            ////    result += i;
            ////}
            ////Console.WriteLine(result);

            ////while (loop)
            ////{
            ////    Console.WriteLine(counter);
            ////    counter++;
            ////    if(counter > 1000)
            ////    {
            ////        loop = false;
            ////    }
            ////}

            ////counter = 0;

            ////do
            ////{
            ////    Console.WriteLine(counter);
            ////    counter++;
            ////} while (counter >= 1000);

            ////string name = "";
            ////do
            ////{
            ////    Console.WriteLine("Please enter your name.");
            ////    name = Console.ReadLine();
            ////} while (name == "");

            //Console.WriteLine("What is your age?");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 21)
            //{
            //    Console.WriteLine("You can drink!");
            //}
            //else if (age >= 18)
            //{
            //    Console.WriteLine("You can vote!");
            //}
            //else
            //{
            //    Console.WriteLine("You are too young.");
            //}
            ////Console.WriteLine();
            ////ugly -> x <= y && a == b && false

            //int visitCount =4;
            //switch (visitCount)
            //{
            //    case 0: Console.WriteLine("Welcome to my website!");
            //        break;
            //    case 1: Console.WriteLine("Welcome back!");
            //        break;
            //    case 2: Console.WriteLine("You really missed me huh?");
            //        break;
            //    default: Console.WriteLine("You can't stay away can you?");
            //        break;
            //}
        }
    }
}
