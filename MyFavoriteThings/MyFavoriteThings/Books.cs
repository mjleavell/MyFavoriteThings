using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Books
    {
        // ------------ PROPERTIES ------------
        public string Name { get; set; }
        public string Author { get; set; }
        public BookGenre Genre { get; set; }

        // ------------ METHODS ------------
        public void bestBook()
        {
            if (Genre == BookGenre.Fiction)
            {
                Console.WriteLine("Yes! Fiction is the best");
            }
            else
            {
                Console.WriteLine("Why don't you like Fiction?");
            }
        }

        public void place()
        {
            Console.WriteLine("I love reading at the beach");
        }
    }

    enum BookGenre
    {
        Biography,
        Fiction,
        History,
        Kids,
        Mystery,
        Religion,
        SciFi
    }
}
