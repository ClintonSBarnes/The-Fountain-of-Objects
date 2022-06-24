using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class Advasary
    {
        (int x, int y) _location;

        public void SetLocation((int x, int y ) location)
        {
            _location = location;
        }

        public (int, int) GetLocation()
        { return _location; }
    }
}
