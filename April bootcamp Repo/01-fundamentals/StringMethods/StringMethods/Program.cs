using System;
using System.Text;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            testIndexOf();
            testLastIndexOf();
            testEndsWith();
            testReplace();
            testSplit();
            testSubstring();
            testToUpper(); //works the same as toLower()
            testTrim();
            testStringBuilder();//Not a string method.
        }

        //an alt to string that uses less memory
        static void testStringBuilder()
        {
            //create new string
            StringBuilder strBuild = new StringBuilder("Test!");
            Console.WriteLine(strBuild);
            //append adds to the end
            strBuild.Append("\t Super!");
            Console.WriteLine(strBuild);
            //insert adds to the beginning (or whatever index you need)
            strBuild.Insert(0,"Start");
            Console.WriteLine(strBuild);
            //shows how many characters are in the builder.
            Console.WriteLine(strBuild.Length);
            //Removes at the beginning (or whatever index you need)
            strBuild.Remove(0, 5);
            Console.WriteLine(strBuild);
            Console.WriteLine(strBuild.ToString());
            //Converts string builder into a normal string
            string example = strBuild.ToString();
        }

        static void testTrim()
        {
            string example = "Justin Jones";
            Console.WriteLine(example.Trim());//Removes all spaces at start and end. NOT MIDDLE
            string spaceExample = " Justin Jones ";
            Console.WriteLine($"|{spaceExample}|");
            Console.WriteLine($"|{spaceExample.Trim()}|");
        }

        //ToLower does the same thing. It returns all lowercase instead of uppercase.
        static void testToUpper()
        {
            string example = "Justin Jones";
            Console.WriteLine(example.ToUpper());//Converts all letters to UPPERCASE (or lowercase with ToLower)
            Console.WriteLine("Enter y/n");
            string input = Console.ReadLine();
            if (input.ToUpper() == "Y")
            {
                Console.WriteLine("You entered Y");
            }
            else if (input.ToUpper() == "N")
            {
                Console.WriteLine("You entered N");
            }
            else
            {
                Console.WriteLine("Not a valid choice");
            }
        }

        static void testSubstring()
        {
            string example = "Justin Jones";
            Console.WriteLine(example.Substring(1));//returns everything after index
            Console.WriteLine(example.Substring(1,3));//returns a specific amount after index
            Console.WriteLine(example.Substring(0,1));//returns first letter

            string result = example.Substring(1);
            result = "B" + result;
            Console.WriteLine(result);

            int index = example.IndexOf("J");//Check if J is in program
            if(index == -1)
            {
                Console.WriteLine("Could not find a J");
            }
            else
            {
                string result2 = example.Substring(1);
                result2 = "B" + result2;
                Console.WriteLine(result2);
            }
        }

        static void testSplit()
        {
            string example = "Justin Jones";
            //Console.WriteLine(example.Split(" ")); Displays that it is an array. None of the values
            string[] splitName = example.Split(" ");
            Console.WriteLine(splitName[0]);
            Console.WriteLine(splitName[1]);

            //get an array of numbers (as a string)
            string numList = "1, 2, 3, 4, 5, 6, 7,8,9,10,11, 12";
            string[] splitNums = numList.Split(",");

            //display 1st and last value
            Console.WriteLine(splitNums[0]);
            Console.WriteLine(splitNums[splitNums.Length - 1 ]);

            //display trimmed 1st and last value
            Console.WriteLine(splitNums[0].Trim());
            Console.WriteLine(splitNums[splitNums.Length - 1].Trim());

            //Change values at index
            //splitNums[0] = "changed";
            //Console.WriteLine(splitNums[0]);

            //combining last and first value
            string result = splitNums[splitNums.Length - 1] + splitNums[0];
            Console.WriteLine(result);
        }

        static void testReplace()
        {
            string example = "Justin Jones";
            Console.WriteLine(example.Replace("J","B"));//Turns all J's into B's
            string exampleF = example.Replace("J", "B");
            Console.WriteLine(exampleF);
            Console.WriteLine(exampleF.Replace("B", "J"));//Turns all B's into J's
            Console.WriteLine(example.Replace("Justin", ""));//removes my name
            Console.WriteLine(example.Replace(" ", "hjkfasdhfakjshbfsadhkjlbffsdajhlbfsadjhhb"));
            Console.WriteLine(example.Replace(" ",""));//remove all spaces
        }

        static void testEndsWith()
        {
            string example = "Justin Jones";
            //EndsWith
            Console.WriteLine(example.EndsWith("J"));//Checks last spot. returns a bool
            Console.WriteLine(example.EndsWith("Jones"));
            Console.WriteLine(example.EndsWith(" "));
            Console.WriteLine(example.EndsWith("961"));

            if (example.EndsWith("Jones"))
            {
                Console.WriteLine("There is a student with the last name Jones");
            }
            else
            {
                Console.WriteLine("There is no student with the last name Jones");
            }
        }

        static void testLastIndexOf()
        {
            string example = "Justin Jones";
            //LastIndexOf
            Console.WriteLine(example.LastIndexOf("J"));
            Console.WriteLine(example.LastIndexOf("Jones"));
            Console.WriteLine(example.LastIndexOf(" "));
            Console.WriteLine(example.LastIndexOf("961"));

            int index = example.LastIndexOf("J");
            if(index == -1)//J not found
            {
                Console.WriteLine("There is no J in this name");
            }
            else//J found
            {
                Console.WriteLine($"The last J is at index: {index}");
            }
        }

        static void testIndexOf()
        {
            string example = "Justin Jones";
            //IndexOf
            Console.WriteLine(example.IndexOf("J"));
            Console.WriteLine(example.IndexOf("Jones"));
            Console.WriteLine(example.IndexOf(" "));
            Console.WriteLine(example.IndexOf("961"));

            int index = example.IndexOf("Jones");
            if (index == -1)//Not found
            {
                Console.WriteLine("There is no student with the last name Jones");
            }
            else//found
            {
                Console.WriteLine("There is a student with the last name Jones.");
                Console.WriteLine($"Jones is at index: {index}");
            }
        }
    }
}
