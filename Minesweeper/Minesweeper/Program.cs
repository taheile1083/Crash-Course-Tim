using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Board testBoard = new Board(20, 10, 20);
            for (int i = 0; i < testBoard.Area; i++)
            {
                testBoard.CheckMine(i);
                if ((i % testBoard.Width) == (testBoard.Width - 1) )
                {
                    Console.WriteLine("");
                }
            }
            Console.Read();
        }
    }
}