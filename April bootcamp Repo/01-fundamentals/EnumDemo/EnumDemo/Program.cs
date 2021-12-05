using System;

namespace EnumDemo
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    enum Month
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Program
    {
        static void Main(string[] args)
        {
            Level myLevel = Level.Low;//return the enum
            Month myMonth = Month.January;//return the enum
            int myMonthNum = (int)Month.January;//casted month to int
            Console.WriteLine(myLevel);
            Console.WriteLine(myMonth);
            Console.WriteLine(myMonthNum);

            Console.WriteLine("Which month would you like to see? 0-11");
            int choice = int.Parse(Console.ReadLine());
            //get associated value
            Month monthChoice = (Month)choice;
            Console.WriteLine(monthChoice);
        }
    }
}
