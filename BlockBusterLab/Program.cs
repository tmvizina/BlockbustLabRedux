using System;
using System.Collections.Generic;

namespace BlockBusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster LastOne = new Blockbuster();
            Console.WriteLine("Welcome to Blockbuster!");

            LastOne.PrintMovies(LastOne.Movies);

            Movie userSelection=LastOne.CheckOut();



            Console.WriteLine("Would you like to watch the movie now? (y/n)");

            string answer=Console.ReadLine().ToLower();

            if (answer == "y")
            {
                Console.WriteLine("The whole movie or just Play? (whole or play)");
                string answer2 = Console.ReadLine().ToLower();
                if (answer2 == "whole")
                {
                    userSelection.PlayWholeMovie(userSelection.Scenes);
                }
                else if (answer2 == "play")
                {
                    userSelection.Play();
                }
            }
            else 
            {
                Console.WriteLine("Maybe when you get home then, Have a great night");
            }


        }
    }
}
