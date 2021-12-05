using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[8];//array of 8 ints
            //string[] titles = new string[3];//array of 3 strings
            

            const int TITLE_COUNT = 100;//using a variable
            string[] titles = new string[TITLE_COUNT];

            Console.WriteLine("How many elements?");//getting input, then using it as length
            int elements = int.Parse(Console.ReadLine());
            string[] names = new string[elements];

            //looping through array with for loop
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("What is your name?");
                names[i] = Console.ReadLine();
                //Console.WriteLine(names[i]);
            }
            //create a new loop
            //display every name (element) within the names array
            for(int i = 0; i<names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //practice accessing elements
            titles[0] = "Cat and the Hat";//access the first element.
            Console.WriteLine(titles[0]);

            //practice intializing with values
            int[] ages = {
                23,
                24,
                50,
                10,
                100,
                2,
                1
            };
            Console.WriteLine(ages[3]);//Access a specific element using index
            Console.WriteLine(ages[ages.Length - 1]); //Returns the last value in the array
            //Console.WriteLine(ages[ages.Length]);//This will always throw an out of bounds exception.
            //out of bounds exception is when you are trying to access an element/index that is outside your array
            int total = 0;
            for(int i = 0; i < ages.Length; i++)
            {
                total += ages[i];//saves current age element into total
            }

            //average example
            //int average = ages[0] + ages[1] + ages[2] + ages[3]; reworked. now accouonts for all ages
            int average = total / ages.Length;
            //average = average / 4; reworked. now accouonts for all ages
            Console.WriteLine($"average: {average}" );
            //loop through ages
            for(int i =0; i<ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }

            //ask for input
            Console.WriteLine($"Which age would you like to access? 0-{ages.Length - 1}");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine(ages[choice]); //uses input directly in index

            //Foreach Practice
            double[] prices = {10.15, 12.50, 6.00, 20.00 };//array of 4 doubles

            double[] discounted = prices;

            foreach(double element in prices)
            {
                Console.WriteLine(element);
            }

            double totalD = 0;
            foreach(double price in prices)
            {
                totalD += price;
            }
            double averageD = totalD / prices.Length;
            Console.WriteLine($"Average price of prices: {averageD}");

            //testing saving/editing values
            double storedValue = prices[0];
            Console.WriteLine("Saved. Values before edits");
            Console.WriteLine(prices[0]);
            Console.WriteLine(storedValue);

            storedValue = 0;
            Console.WriteLine("values after edits");
            Console.WriteLine(prices[0]);
            Console.WriteLine(storedValue);

            //Searching for a value
            double search = 6.01;
            bool found = false;
            foreach(double price in prices)
            {
                if (price == search)
                {
                    found = true;
                }
            }
            Console.WriteLine($"Able to find the value: {found}");//displays true or false 

            //testing method with array param
            Console.WriteLine($"Total of all prices: {AddArray(prices)}");

            double[] freePrices = ConvertToZero(prices);
            DisplayArray(freePrices);

            //two dimensional array
            int[,] array2d = new int[3, 4]
            {
                {0,1,2,3 },
                {4,5,6,7 },
                {8,9,10,11 }
            };

            Console.WriteLine(array2d[1,2]);

        }

        static void DisplayArray(double[] nums)
        {
            foreach (double num in nums)
            {
                Console.WriteLine(num);
            }
        }

        static double AddArray(double[] nums)
        {
            double result = 0;
            foreach(double number in nums)
            {
                result += number;
            }
            return result;
        }

        static double[] ConvertToZero(double[] nums)
        {
            //Cannot use foreach to change values within array
            for(int i = 0;i < nums.Length; i++)
            {
                nums[i] = 0;//changes all values to 0
            }
            return nums;
        }
    }
}
