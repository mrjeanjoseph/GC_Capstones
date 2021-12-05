using System;

namespace PigLatinExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            bool runProgram = true;
            while(runProgram)//loop program
            {
                Console.WriteLine("Enter a line to be translated.");//get translated word
                string word = Console.ReadLine();
                word = word.ToLower();
                string result= "";

                //starts with vowel
                if (word.StartsWith("a") || word.StartsWith("e") || word.StartsWith("i") || word.StartsWith("o") || word.StartsWith("u"))
                {
                    result = word + "way";
                }
                else//consonant
                {
                    for(int i = 0; i < word.Length; i++)
                    {
                        //Console.WriteLine(word.Substring(i,1)); testing
                        if(word.Substring(i, 1) == "a" || word.Substring(i, 1) == "e" || word.Substring(i, 1) == "i" || word.Substring(i, 1) == "o" || word.Substring(i, 1) == "u")
                        {
                            //Console.WriteLine(word.Substring(0,i));//move to end testing
                            //Console.WriteLine(word.Substring(i));//move to beginning testing
                            result = word.Substring(i) + word.Substring(0, i) + "ay";
                            break; // found our word. Need to exit loop
                        }
                    }
                }

                Console.WriteLine(result);

                Console.WriteLine("Translate another line? y/n");
                while(true)
                {
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        break;
                    }
                    else if (choice == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a y/n");
                    }
                }
            }
        }
    }
}
