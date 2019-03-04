using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Pets
    {
        // ------------ PROPERTIES ------------
        public string Name { get; set; }
        public string Age { get; set; }
        public string Color { get; set; }
        public PetType Type { get; set; }

        // ------------ METHODS ------------
        public void fetch()
        {
            Console.WriteLine("Chasing after a yellow tennis ball is my favorite thing!");
        }

        public void tricks()
        {
            Console.WriteLine("Sit, stay, lay down, roll over are the best tricks");
        }
    }

    enum PetType
    {
        Labrador,
        Corgi,
        Poodle,
        Retriever
    }
}
