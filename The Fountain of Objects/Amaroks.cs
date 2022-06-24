using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class Amaroks: Advasary
    {
        static  (int, int) _location;

        //*****only outward facing methods******
        public static void AmaroksSetUp(int difficulty)
        {
            if (difficulty == 4)
            {
                AmaroksGenerator(1, 4);
            }
            else if (difficulty == 6)
            {
                AmaroksGenerator(2, 6);
            }
            else
            {
                AmaroksGenerator(3, 8);
            }
        }
        public (int, int) GetLocation()
        {
            return _location;
        }

        //utility methods - protected for use only in this class.
        //builds and sets the location of the Amaroks randomly
        private static void AmaroksGenerator(int Count, int size)
        {
            for (int i = 0; i < Count; i++)
            {
                new Pit();
                EstablishAmaroks(size);

            }
        }
        private static void EstablishAmaroks(int size)
        {

            Random number = new Random();
            SetAmaroks((number.Next(1, size), number.Next(1, size)));

        }

        private static void SetAmaroks((int x, int y) location)
        {
            _location = (location);
        }
    }
}
