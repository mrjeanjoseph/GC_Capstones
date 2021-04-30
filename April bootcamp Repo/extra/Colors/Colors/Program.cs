using System;
using System.Collections.Generic;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string> {
                "Red",
                "White",
                "Blue",
                "Green",
                "Yellow"
            };
            List<string> backgroundColors = new List<string> {
                "Yellow",
                "Red",
                "White",
                "Blue",
                "Green"
            };
            foreach (string color in colors)
            {
                ChangeColor(color);
                Console.WriteLine(color);
            }
            foreach (string color in backgroundColors)
            {
                ChangeBackgroundColor(color);
                Console.WriteLine(color);
            }
            //resets background and font color
            Console.ResetColor();
            Console.WriteLine("Hello this is a test");
        }



        static void ChangeColor(string color)
        {
            //forground is font
            if(color.ToLower().Contains("red"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color.ToLower().Contains("white"))
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color.ToLower().Contains("blue"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color.ToLower().Contains("green"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color.ToLower().Contains("yellow"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        static void ChangeBackgroundColor(string color)
        {
            //background
            if (color.ToLower().Contains("red"))
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (color.ToLower().Contains("white"))
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else if (color.ToLower().Contains("blue"))
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (color.ToLower().Contains("green"))
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (color.ToLower().Contains("yellow"))
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
        }
    }
}
