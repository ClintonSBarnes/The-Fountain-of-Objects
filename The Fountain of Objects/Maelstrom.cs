using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class Maelstrom : Advasary
    {
        private static (int, int) _location;


        //*****only outward facing methods******
        public static void MaelstromSetUp(int difficulty)
        {
            if (difficulty == 4)
            {
                MaelstromGenerator(1, 4);
            }
            else if (difficulty == 6)
            {
                MaelstromGenerator(1, 6);
            }
            else if (difficulty == 8)
            {
                MaelstromGenerator(2, 8);
            }
        }

        public (int,int)  GetLocation()
        {
            return _location;
        }
       


        //utility methods - protected for use only in this class.
        //builds and sets the location of the Maelstrom randomly
        private static void MaelstromGenerator(int MaelstomCount, int size)
        {
            for (int i = 0; i < MaelstomCount; i++)
            {
                new Maelstrom();
                EstablishMaelstrom(size);

            }
        }

        private static void EstablishMaelstrom(int size)
        {

            Random number = new Random();
            SetMaelstrom((number.Next(1, size), number.Next(1, size)));

        }

        private static void SetMaelstrom((int x, int y) location)
        {
            _location = (location);
        }
    }
}