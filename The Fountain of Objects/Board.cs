using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Fountain_of_Objects
{
    internal class Board
    {
        private int[,] coordinates4 = new int[4, 4];
        private int[,] coordinates6 = new int[6,6];
        private int[,] coordinates8 = new int [8,8];
        private bool _validBoard = false;
        private int _size;


        public void SetBoardSize(int size)
        {
            if (size == 4 || size == 6 || size == 8)
                _size = size;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    coordinates4[i, j] = j;

            }


        }

        public void SetValidBoard(bool check)
        {
            _validBoard = check;
        }

        public bool GetValidBoard()
        {
            return _validBoard;
        }

        public int GetSize()
        { return _size; }
    }
}
