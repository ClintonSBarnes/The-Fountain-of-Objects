using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class Fountain
    {
        bool fountainOn;
        bool fountainInRoom;
        (int x, int y) fountainLocation;

        public bool GetFountainOn()
        {
            return fountainOn;
        }
        public bool IsFoutainNear((int x,int y) player)
        {
            if (player == fountainLocation)
            {
                return true;
            }
            else return false;
        }

        public void EstablishFountain(int size)
        {
            
            Random number = new Random();
            SetFountain((number.Next(1, size), number.Next(1,size)));
            
        }

        public void SetFountain((int x, int y) location)
        {
            fountainLocation = (location);
        }


    }
}
