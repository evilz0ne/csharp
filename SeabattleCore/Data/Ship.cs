using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seabattle.Data
{
    public class Ship
    {
        public Cell[] Cells;
        //construct default
        public Ship()
        {

        }

        //construct 1 cell ship
        public Ship(int x, int y)
        {
            Cell cell = new Cell()
            {
                X = x,
                Y = y,
                CellState = State.Alive
            };
            Cells = new Cell[1] { cell };
        }



        //construct 2 cell ship
        public Ship(Cell cell, int x, int y)
        {
            Cell cell2 = new Cell()
            {
                X = x,
                Y = y,
                CellState = State.Alive
            };
            Cells = new Cell[2] { cell, cell2 };
        }


        public bool CheckAround(int x, int y)
        {
            if (Cells != null)
            {
                foreach (Cell cell in Cells)
                {
                    if (!cell.CheckAround(x, y))
                    {
                        return false;
                    }
                }
            }
            return true;       
        }
    }
}