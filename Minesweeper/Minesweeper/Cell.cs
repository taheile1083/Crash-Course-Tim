using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Cell
    {
        public bool IsMine = false;
        public int SurroundingMines;

        public int[] location = new int[2];

        public Cell()
        {

        }

        public void SetMine()
        {
            IsMine = true;
        }
        public int FindMines()
        {
            return SurroundingMines;
        }
    }
}