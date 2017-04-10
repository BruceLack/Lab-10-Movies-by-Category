using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("Star Wars", "SciFi"));
            movieList.Add(new Movie("The Hangover", "Comedy"));
            movieList.Add(new Movie("The Exorcist", "Horror"));
            movieList.Add(new Movie("Bladrunner", "SciFi"));
            movieList.Add(new Movie("Super Troopers", "Comedy"));
            movieList.Add(new Movie("The Babadook", "Horror"));
            movieList.Add(new Movie("Serenity", "SciFi"));
            movieList.Add(new Movie("Trading Places", "Comedy"));
            movieList.Add(new Movie("It Follows", "Horror"));
            movieList.Add(new Movie("The Martian", "SciFi"));

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies in this list.");
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("What category are you interested in? (1 for SciFi/ 2 for Comedy/ 3 for Horror)");
                string selectedGenre = "";
                int selectedNumber;
                try
                {
                    selectedNumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    selectedNumber = 0;
                }
                
                if (selectedNumber == 1)
                {
                    selectedGenre = "SciFi";
                }
                else if (selectedNumber == 2)
                {
                    selectedGenre = "Comedy";
                }
                else if (selectedNumber == 3)
                {
                    selectedGenre = "Horror";
                }
                else if (selectedNumber <1 || selectedNumber >3)
                {
                    Console.WriteLine("That input is invalid.");
                }

                foreach (Movie Movie in movieList)
                {
                    if (Movie.GetGenre() == selectedGenre)
                    {
                        Console.WriteLine(Movie.GetTitle());
                    }
                }

                run = Continue();

            }
        }

        public static Boolean Continue()
        {
            Console.WriteLine("Would you like to continue? (Y/N): ");
            string input = Console.ReadLine().ToLower();
            Boolean run = true;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Goodbye!");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
                run = Continue();
            }

            return run;
        }
    }
}
