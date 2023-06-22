using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_game
{
    class Game
    {
        int size;
        int[,] map;

        public Game (int size)
        {
            if (size < 2) size = 2;
            if (size > 5) size = 5;
            this.size = size;
            map = new int [size, size];
        }
    }
}
