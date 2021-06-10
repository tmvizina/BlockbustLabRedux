using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    abstract class Movie
    {

        public enum Genre
        {
            //Movie Genre Types
            Drama,
            Horror,
            Comedy,
            Romance,
            Action
        }


        //This class is a container class for storing Movie Name as well as Genre

        public string Name { get; set; }

        public Genre genre { get; set; }

        public int Runtime { get; set; }// in minutes

       public List<string> Scenes { get; set; }



        //This is the constructer method that combines all the data
        public Movie(string name, Genre genre, int runtime, List<string> scenes)
        {
            Name = name;

            this.genre = genre;

            Runtime = runtime;

            List<string>Scenes=new List<string>();
        }

        public abstract void Play();

        public abstract void PlayWholeMovie(List<string> scenes);

        public virtual void PrintInfo(string name, Genre genre, int runtime)
        {
            Console.WriteLine($"Movie Title: {name}");
            Console.WriteLine($"Genre: {genre}");
            Console.WriteLine($"Runtime (min) : {runtime}");
        }

        public virtual void PrintScenes(List<string> scenes)
        {
            for (int i = 0; i < scenes.Count; i++)
            { 
                Console.WriteLine($"{i}). \t{scenes[i]}");
            }
        }
    }
}
