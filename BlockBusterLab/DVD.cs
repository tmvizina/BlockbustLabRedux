using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class DVD:Movie
    {


        public List<string> Scenes { get; set; }
        public List<string> SceneNames { get; set; }

        //This is the constructer method that combines all the data
        public DVD(string name, Genre genre, int runtime, List<string> scenes,List<string> sceneNames) : base(name, genre, runtime, scenes)
        {
            SceneNames = sceneNames;
            Scenes = scenes;
        }
        //first asks the user which scene they would like to watch
        //then displays all available scenes and their chapter titles
        //print out the users selected scene

        public override void Play()
        {
            Console.WriteLine("Select a scene ");
            for (int i = 0; i < this.SceneNames.Count ; i++)
            {
                Console.WriteLine($"{i}). \t {this.SceneNames[i]}");
            }

            int movieselected = int.Parse(Console.ReadLine());

            Console.WriteLine($"Scene selected is : \n {this.Scenes[movieselected]}");

            
        }
        public override void PlayWholeMovie(List<string> scenes)
        {
            Console.WriteLine("Piracy is not a victimless crime! You wouldn't download a car!");
            for (int i = 0; i < this.Scenes.Count; i++)
            {
                Console.WriteLine($"\n{this.Scenes[i]}");
            }
        }

    }
}
