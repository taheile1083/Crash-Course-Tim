using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Board
    {
        public int Width;
        public int Height;
        public int Area;
        public int Mines;

        List<Cell> Cells = new List<Cell>();

        public Board(int W, int H, int M)
        {
            Width = W;
            Height = H;
            Area = (W * H);
            Mines = M;

            for (int i = 0; i < Area; i++)
            {
                Cell newCell = new Cell();
                newCell.location[0] = (i / W);
                newCell.location[1] = (i % W);
                Cells.Add(newCell);
            }

            for (int i = 0; i < M; i++)
            {
                Random R = new Random();
                int r = R.Next(Area);
                if (!Cells.ElementAt(r).IsMine)
                {
                    Cells.ElementAt(r).IsMine = true;
                } else
                {
                    i--;
                }
            }
            for (int i = 0; i < Area; i++)
            {
                if (Cells.ElementAt(i).IsMine)
                {
                    //Cell to the Right
                    if ((i % Width) != (Width - 1))
                    {
                        Cells.ElementAt((i + 1)).SurroundingMines++;
                    }
                    //Cell to the Left
                    if ((i % Width) != 0)
                    {
                        Cells.ElementAt((i - 1)).SurroundingMines++;
                    }
                    //Cell to the Top
                    if ((i / Width) != 0)
                    {
                        Cells.ElementAt((i - Width)).SurroundingMines++;
                        //Cell to the Top Right
                        if ((i % Width) != (Width - 1))
                        {
                            Cells.ElementAt((i - Width + 1)).SurroundingMines++;
                        }
                        //Cell to the Top Left
                        if ((i % Width) != 0)
                        {
                            Cells.ElementAt((i - Width - 1)).SurroundingMines++;
                        }
                    }
                    //Cells to the Bottom
                    if ((i / Width) != (Height - 1))
                    {
                        Cells.ElementAt((i + Width)).SurroundingMines++;
                        //Cell to the Bottom Right
                        if ((i % Width) != (Width - 1))
                        {
                            Cells.ElementAt((i + Width + 1)).SurroundingMines++;
                        }
                        //Cell to the Bottom Left
                        if ((i % Width) != 0)
                        {
                            Cells.ElementAt((i + Width - 1)).SurroundingMines++;
                        }
                    }
                }
            }

        }

        public void CheckMine(int i)
        {
            if (Cells.ElementAt(i).IsMine)
            {
                Console.Write(" B");
            } else if (Cells.ElementAt(i).SurroundingMines > 0)
            {
                Console.Write(" "+Cells.ElementAt(i).SurroundingMines);
            } else {
                Console.Write("[]");
            }
        }
    }
}