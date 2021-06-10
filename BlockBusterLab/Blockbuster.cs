using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBusterLab
{
    class Blockbuster
    {

        public List<Movie> Movies { get; set; } = new List<Movie>();
        

        // You can intiialize a value but you can't call methods outside of methods within a class
        // Movies.Add(new VHS("Die Hard", Movie.Genre.Action, 134, DieHardScenes));

        public  Blockbuster()
        {
           
            List<Movie> movies = new List<Movie>();
          

            //DVD
            List<string> ShrekScenes = new List<string>();
            List<string> ShrekSceneNames = new List<string>();
            List<string> nemoScenes = new List<string>();
            List<string> nemoSceneNames = new List<string>();
            List<string> spaceballsScenes = new List<string>();
            List<string> spaceballsSceneNames = new List<string>();



            //VHS 
            List<string> DieHardScenes = new List<string>();
            List<string> LOTRScenes = new List<string>();
            List<string> nightmareScenes = new List<string>();

            //SpaceBalls

            // plot credit taken from https://en.wikipedia.org/wiki/Spaceballs
            string spaceballs0 = "Planet Spaceball, led by the incompetent President Skroob, has squandered all of its fresh air. Skroob schemes to force King Roland of the neighboring planet Druidia to give them the code to the shield that protects Druidia, allowing them to steal all their air, by kidnapping his daughter Princess Vespa on the day of her arranged marriage to the narcoleptic Prince Valium. Skroob sends the villainous Dark Helmet to complete this task with Spaceball One, an impossibly huge ship commanded by Colonel Sandurz. Before they can arrive, Vespa abandons her wedding and flees the planet in her Mercedes spaceship with her droid of honor, Roland contacts mercenary Lone Starr and his mawg companion Barf, offering a lucrative reward to retrieve Vespa before she is captured. Lone Starr readily accepts, as he is in major debt to gangster Pizza the Hutt. In their Winnebago spaceship, Eagle 5, Lone Starr and Barf are able to reach Vespa before Spaceball One, rescue both her and Dot, then escape. Spaceball One tries to follow alight-speed, but Helmet orders the ship to ludicrous speed, causing it to overshoot the escapees by a large distance.";
            string spaceballs1 = "Out of fuel, Lone Starr is forced to crash-land on the nearby desert moon of Vega. The group travels on foot in order to evade the Spaceballs, but they eventually pass out under the blazing sun. They are found by the Dinks, a group of diminutive sparkly brown-clad aliens, and are taken to a cave occupied by the sage Yogurt, who introduces the group and the audience to the film's merchandising campaign. Yogurt later teaches Lone Starr about the metaphysical power known as the the Schwartz, and gives him a ring which can be used to control the Upside of the Schwartz. During this time, Lone Starr and Vespa develop romantic feelings for each other, but Vespa insists she can only marry a prince. Helmet and Sandurz break the fourth wall by using a VHS copy of Spaceballs to discover Vespa's location, and Helmet orders Spaceball One to go to the moon of Vega. When Helmet discovers Yogurt's lair, he lures Vespa out by pretending to be Roland and captures both her and Dot, taking them back to planet Spaceball. He then threatens to reverse Vespa's nose job, forcing Roland to reveal the code to Druidia's shield. Helmet and Sandurz take Spaceball One to Druidia, while Lone Starr and Barf rescue Vespa and Dot from the Spaceballs prison complex. When they arrive at Druidia, Spaceball One transforms into Mega Maid, a Statue of Liberty-like colossal robot maid with a vacuum cleaner. The vacuum is activated and begins sucking the air off the planet. When the vacuum bag is almost full, Lone Starr uses the Schwartz to reverse the vacuum, blowing the air back onto the planet.";
            string spaceballs2 = "The group then enters Mega Maid and attempts to destroy it. Helmet intercepts Lone Starr and reveals that he is his father's brother's nephew's cousin's former roommate. Lone Starr and Helmet fight using lightsaber-like weapons created by their Schwartz-rings, until the former loses his ring. Yogurt speaks to Lone Starr, telling him that the ring was a Cracker Jack box prize and that the real Schwartz is inside him. Lone Starr defeats Helmet, causing him to involuntarily strike the self-destruct button. Lone Starr and his friends escape the ship, while Skroob, Helmet, and Sandurz fail to reach any escape pods in time, trapping them in the robot's head as the ship explodes. They subsequently crash-land on a nearby planet, much to the chagrin of its Planet of the Apes-like population.";
            string spaceballs3 = "With Lone Starr's debt to Pizza nullified by the gangster's untimely death, he returns Vespa to Roland and leaves, taking only enough money to cover his expenses. After a lunch break at a diner and a strange incident involving an alien and an astronaut similar to the events in Alien, Lone Starr finds a final message from Yogurt, informing him that the medallion necklace Lone Starr has been wearing reveals that he is a prince, and thus eligible to marry Vespa. He reaches Druidia in time to stop her wedding to Valium, announces his royal lineage, then marries Vespa.";

            spaceballsScenes.Add(spaceballs0);
            spaceballsScenes.Add(spaceballs1);
            spaceballsScenes.Add(spaceballs2);
            spaceballsScenes.Add(spaceballs3);

            string name_spaceballs0 = "Planet SpaceBall and Eagle 5";
            string name_spaceballs1 = "Into the Desert";
            string name_spaceballs2 = "The Mega Maid";
            string name_spaceballs3 = "The Tragedy of Pizza the Hut";

            spaceballsSceneNames.Add(name_spaceballs0);
            spaceballsSceneNames.Add(name_spaceballs1);
            spaceballsSceneNames.Add(name_spaceballs2);
            spaceballsSceneNames.Add(name_spaceballs3);

            DVD spaceballs = new DVD("Spaceballs", Movie.Genre.Comedy, 96, spaceballsScenes, spaceballsSceneNames);

            //Finding Nemo
            // synopsis source http://festivals.iloveindia.com/childrens-day/animated-movies/finding-nemo.html
            string nemo0 = "Marlin is a fretful and apprehensive Ocellaris clownfish living in the Great Barrier Reef. He is very protective of his only child, Nemo after his wife, Coral, and other offspring were killed by a barracuda. Marlin is worried about Nemo's swimming ability due to his abnormally small right fin which Nemo considers it to be his lucky fin. Nemo is sent to school but elopes on the first day thereby toughing the bottom of a boat. This starts an argument between the father and son. Eventually, Nemo is captured by a scuba driver and taken away in the boat.";
            string nemo1 = "Marlin meets Dory, a native and optimistic blue tang fish with short-term memory loss, in search of help to find Nemo. He meets would-be vegetarian sharks, Bruce, Anchor and Chum and finds a diver's mask dropped from the boat. While struggling with an angler fish in the deep sea, Dory notes down the address on the mask as Sydney, Australia. Hence, Marlin and Dory set out to find Sydney. While sharing his story with a number of young turtles on the way, Marlin's story reaches Sydney through word of mouth.";
            string nemo2 = "Coming back to Nemo, the dentist who captured him drops him into a fish tank in his office in Sydney Harbor. He meets a group of fish called the Tank Gang in the tank. Gill, a crafty and ambitious moorish idol fish is the leader. The fish come to know that Nemo would be given to the dentist's niece Darla who killed a pet fish previously by shaking a bag of water. Thus, starts the journey of Nemo trying to escape with the help of Gil and Nigel, the pelican. Marlin and Dory somehow manage to reach Sydney and meet Nigel who informs them about Nemo.";
            string nemo3 = "The dentist is about to give Nemo to Darla who pretends to be dead. Unfortunately, even Marlin assumes Nemo to be dead. Disheartened, he leaves for home. Gill helps Nemo to escape through a drain. Dory and Nemo encounter. Initially, though Dory is confused due to her memory loss, recognizes Nemo and remembers Marlin's goal. Dory helps Nemo to reunite with his father, Marlin. Both are delighted, but Dory is caught in fishing net along with other fish. Nemo swims to help the fish and Dory escape as an attempt to make his father realize that he can be trusted. Marlin, Nemo and Dory return back home happily.";

            nemoScenes.Add(nemo0);
            nemoScenes.Add(nemo1);
            nemoScenes.Add(nemo2);
            nemoScenes.Add(nemo3);

            string name_nemo0 = "Nemo Lost";
            string name_nemo1 = "Sydney";
            string name_nemo2 = "Tank Gang";
            string name_nemo3 = "The Ending";

            nemoSceneNames.Add(name_nemo0);
            nemoSceneNames.Add(name_nemo1);
            nemoSceneNames.Add(name_nemo2);
            nemoSceneNames.Add(name_nemo3);

            DVD nemo = new DVD("Finding Nemo", Movie.Genre.Drama, 100, nemoScenes,nemoSceneNames);

            //Shrek
            //Please note that while the code is my own I have taken the liberty of borrowing anothers recounting of the tale of shrek all credit of this goes to https://www.henry.k12.va.us/cms/lib/VA01000023/Centricity/Domain/546/Shrek%20Plot%20Summary.pdf
            string shrek0 = "SHREK is grumpy, smelly, and an ugly ogre living peacefully in a swamp. One night he suddenly finds his land has been inhabited by a mass of fairy-tale creatures(Pinocchio, the three little pigs, Peter Pan, Snow White, and Cinderella amongothers), who have been banished by the evil Lord Farquaad.One of these is Donkey(who just won’t shut up). Accompanied by him, Shrek confronts Lord Farquaad, demanding his land back. Farquaad gives him a deal, telling him to rescue Princess Fiona from a dragon-guarded castle, to get his swamp back.";
            string shrek1 = "Shrek  and  Donkey  go  and  rescue  the  Princess,  narrowly  avoiding  being  burned  by   the Dragon, who  tries to  seduce Donkey(being a  girl Dragon!).  Fiona  is  disgruntled about  being rescued  by an  ugly ogre, rather  than Prince  Charming.However,  despite their  differences,  she and  Shrek grow  fond of  each other.  ";
            string shrek2 = "On  the  second  night  of  their  return  journey,  Fiona  hides  in  a  windmill.  Donkey  finds   her,  and discovers  that she’s turned  into an  ogress.She explains  that she’s under  a spell, which  can only  be broken  by  true  love’s first  kiss.Shrek overhears  part of  this, but  misunderstands and  thinks she  doesn’t love  him because  he’s ugly.Just  as  she decides  to tell  Shrek the  truth, the sun  rises and  she becomes  a beautiful  princess again.  Lord Farquaad  arrives and  takes Fiona  to his  castle, and Shrek  returns to  his swamp.  Both are  miserable.";
            string shrek3 = "Later,  Shrek,  Donkey,  and  Dragon  head  to  Farquaad’s  castle,  to  try  to  stop  Fiona   marrying him.He  tells Fiona  of Farquaad’s  true  intentions of  marrying her.  When they  arrive, the sun  sets and  Fiona becomes  an ogress  again.Farquaad doesn’t want to marry  her, and sets  the guards  on everybody, but Dragon  comes to  the rescue  and eats  Farquaad up.  Shrek and  Fiona kiss.  Therefore, Fiona stays  ugly  (in conformity with  the spell:  “you find  true  love’s first  kiss and  then take  love’s  true  form”).  Fiona will  forever be  an ugly  ogre like  Shrek.She marries  Shrek  in  a big  wedding with  all the  fairy tale  creatures,  and they  live  “ugly”  ever after.  ";

            ShrekScenes.Add(shrek0);
            ShrekScenes.Add(shrek1);
            ShrekScenes.Add(shrek2);
            ShrekScenes.Add(shrek3);

            string name_shrek0 = "Get Out of My Swamp";
            string name_shrek1 = "Save the Princess";
            string name_shrek2 = "The windmill and the spell";
            string name_shrek3 = "The End";

            ShrekSceneNames.Add(name_shrek0);
            ShrekSceneNames.Add(name_shrek1);
            ShrekSceneNames.Add(name_shrek2);
            ShrekSceneNames.Add(name_shrek3);

            DVD shrek = new DVD("Shrek", Movie.Genre.Romance, 95, ShrekScenes, ShrekSceneNames);

            //Die Hard
            string diehard0 = "Beginning";
            string diehard1 = "first middle";
            string diehard2 = "second middle";
            string diehard3 = "ending";

            DieHardScenes.Add(diehard0);
            DieHardScenes.Add(diehard1);
            DieHardScenes.Add(diehard2);
            DieHardScenes.Add(diehard3);

            VHS diehard = new VHS("Die Hard", Movie.Genre.Action, 134, DieHardScenes);

            //Fellowship of the Ring
            string LOTR0 = "hobbiton";
            string LOTR1 = "fireworks";
            string LOTR2 = "mines of moria";
            string LOTR3 = "orcs attack";

            LOTRScenes.Add(LOTR0);
            LOTRScenes.Add(LOTR1);
            LOTRScenes.Add(LOTR2);
            LOTRScenes.Add(LOTR3);
            
            VHS LOTR = new VHS("The Fellowship of the Ring", Movie.Genre.Action,225, LOTRScenes);
            

            //Nightmare on Elm Street
            VHS nightmare = new VHS("Nightmare on Elm Street", Movie.Genre.Horror, 101, nightmareScenes);

            string nightmare0 = "Tina Nightmare";
            string nightmare1 = "Tina's Dead!";
            string nightmare2 = "Kruger escapes police";
            string nightmare3 = "Car locks them in and drives away";

            nightmareScenes.Add(nightmare0);
            nightmareScenes.Add(nightmare1);
            nightmareScenes.Add(nightmare2);
            nightmareScenes.Add(nightmare3);

            movies.Add(shrek);
            movies.Add(diehard);
            movies.Add(LOTR);
            movies.Add(nightmare);
            movies.Add(nemo);
            movies.Add(spaceballs);

              this.Movies = movies;
    }

        public  void PrintMovies(List<Movie> movies)
        {
           

            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i}). {movies[i].Name}");
            }
        }

        public Movie CheckOut()
        {
            //PrintMovies();

            Console.WriteLine("Which Movie would you like to check out? ");

            int movieChosen = int.Parse(Console.ReadLine());

            this.Movies[movieChosen].PrintInfo(this.Movies[movieChosen].Name, this.Movies[movieChosen].genre, this.Movies[movieChosen].Runtime);

            return Movies[movieChosen];
        }
    }
}
