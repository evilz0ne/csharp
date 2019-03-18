using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seabattle.Data
{
    public class Field
    {
        public Ship[] Ships;
        /// <summary>
        /// add 1 cell ship
        /// </summary>
        /// <param name="x">abscis</param>
        /// <param name="y">ordinat</param>
        

        public bool CheckAround(int x, int y)
        {
            if (Ships != null )
            foreach (Ship ship in Ships)
            {
                if (!ship.CheckAround(x, y))
                {
                    return false;
                }
            }
            return true;
        }
        // 1 button ship
        public void Addship1(int x, int y)
        {
            var ship = new Ship(x, y);
            if (Ships == null)
            {
                Ships = new Ship[1] { ship };
            }
            else
            {
                List<Ship> list = Ships.ToList();
                list.Add(ship);
                Ships = list.ToArray();

            }
        }

        // 2 button ship
        public void Addship2(Cell cell, int x, int y)
        {
            var ship = new Ship(cell,x, y);
            if (Ships == null)
            {
                Ships = new Ship[1] { ship };
            }
            else
            {
                Array.Resize(ref Ships, Ships.Length + 1);
                Ships[Ships.Length - 1] = ship;

            }
        }
    }
}
