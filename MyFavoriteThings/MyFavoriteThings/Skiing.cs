using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Skiing
    {
        // ------------ PROPERTIES ------------
        public string Name { get; set; }
        public string City { get; set; }
        public SkiingState State { get; set; }
        public SkiType Type { get; set; }

        // ------------ METHODS ------------
        public void skiOrBoard()
        {
            if (Type == SkiType.Ski)
            {
                Console.WriteLine("Yes! Skiing is the best");
            }
            else
            {
                Console.WriteLine("Why don't you ski?");
            }
        }

        public void powder()
        {
            Console.WriteLine("Nothing beats fresh powder!");
        }
    }

    enum SkiingState
    {
        Colorado,
        Utah,
        California,
        Canada,
        Switzerland,
        Austria,
        France,
        Oregon,
        Wyoming,
        Montana,
        Vermont
    }

    enum SkiType{ Ski, Snowboard }
}
