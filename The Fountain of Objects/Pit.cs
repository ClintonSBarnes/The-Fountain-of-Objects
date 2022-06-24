using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class Pit : Advasary
    {
        private static (int, int) _location;

        //*****only outward facing methods******
        public static void PitSetUp(int difficulty)
        {
            if (difficulty == 4)
            {
                PitGenerator(1, 4);
            }
            else if (difficulty == 6)
            {
                PitGenerator(2, 6);
            }
            else
            {
                PitGenerator(4, 8);
            }
        }
        public (int, int) GetLocation()
        {
            return _location;
        }

        //utility methods - protected for use only in this class.
        //builds and sets the location of the Pit randomly
        private static void PitGenerator(int Count, int size)
        {
            for (int i = 0; i < Count; i++)
            {
                new Pit();
                EstablishPit(size);

            }
        }
        private static void EstablishPit(int size)
        {

            Random number = new Random();
            SetPit((number.Next(1, size), number.Next(1, size)));

        }

        private static void SetPit((int x, int y) location)
        {
            _location = (location);
        }
    }
}
