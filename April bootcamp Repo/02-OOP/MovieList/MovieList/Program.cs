using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("Star Wars","scifi"),
                new Movie("Finding Nemo", "animated"),
                new Movie("Fast and the Furious", "drama"),
                new Movie("Pursuit of Happiness", "drama"),
                new Movie("Star Trek", "scifi"),
                new Movie("Up", "animated"),
                new Movie("Saw", "horror"),
                new Movie("Final Destination", "horror"),
                new Movie("Cinderella", "animated"),
                new Movie("Ferris Buellers Day Off", "Comedy")
            };

            Console.WriteLine("Welcome to the movie list.");

            bool runProgram = true;
            while (runProgram)
            {

                String input = "";
                Console.WriteLine("Please enter a movie category.");
                //Validate
                while (true)
                {
                    input = Console.ReadLine().Trim().ToLower();
                    if (input == "")
                    {
                        Console.WriteLine("Please enter a category.");
                    }
                    else
                    {
                        break;
                    }
                }

                //Display if category matches
                foreach (Movie movie in movies)
                {
                    if (movie.Category.Trim().ToLower() == input)
                    {
                        Console.WriteLine(movie.Title);
                    }
                }

                Console.WriteLine("Would you like to continue? y/n");

                while(true)
                {
                    string choice = Console.ReadLine().Trim().ToLower();
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
                        Console.WriteLine("That was not a valid input.");
                    }
                }
            }
        }
    }
}
