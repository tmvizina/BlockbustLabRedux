using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class VHS:Movie
    {
        public int Currenttime { get; set; }// in minutes

        //This is the constructer method that combines all the data
        //it also assumes the Movie is rewing
        public VHS(string name, Genre genre, int runtime, List<string> scenes):base(name,genre,runtime,scenes)
        {
 

            Currenttime = 0;

        }

        public override void Play()
        {
            //play scene at current time and increment currenttime up by one
            Console.WriteLine(this.Scenes[this.Currenttime]);
            this.Currenttime++;
            

        }

        public void Rewind(int currenttime)
        {
            currenttime = 0;
        }

        public void PlayWholeMovie(List<string> scenes)
        {
            Console.WriteLine("Piracy is not a victimless crime! You wouldn't download a car!");
            for (int i = 0; i < scenes.Count; i++)
            {
                Console.WriteLine($"\n{scenes[i]}");
            }
        }
    }
}
