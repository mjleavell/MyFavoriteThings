using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class TV
    {
        // ------------ PROPERTIES ------------
        public string Name { get; set; }
        public string Actors { get; set; }
        public TVNetwork Network { get; set; }

        // ------------ METHODS ------------
        public void bestNetwork()
        {
            if (Network == TVNetwork.Netflix)
            {
                Console.WriteLine("Did you Netflix and Chill?");
            }
            else
            {
                Console.WriteLine("You must not like quality TV Shows.");
            }
        }

        public void bestShow()
        {
            if (Name == "Grey's Anatomy")
            {
                Console.WriteLine("Congrats! You picked the best show ever!");
            }
            else
            {
                Console.WriteLine("You need better taste in TV shows.");
            }
        }
    }



    enum TVNetwork
    {
        ABC,
        NBC,
        CBS,
        FOX,
        USA,
        TBS,
        Bravo,
        Netflix,
        Amazon,
        HBO,
        Hulu
    }
}
