using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class Player
    {
        (int X, int Y) _playerLocation = (0, 0);
        int _arrowCount;

        public void EstablishArrowCount()
        {
            _arrowCount = 20;//this will need to be updated based on the size of the map.

        }
        public int GetArrowCount()
        {
            return _arrowCount;
        }
        public int GetPlayerXLocation()
        {
            return _playerLocation.X;
        }

        public int GetPlayerYLocation()
        {
            return _playerLocation.Y;
        }

        public void SetPlayerLocation((int x, int y) tup)
        {
            _playerLocation.X = tup.x;
            _playerLocation.Y = tup.y;
        }
    }
}
