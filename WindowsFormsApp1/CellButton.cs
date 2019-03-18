using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seabattle
{
    public class CellButton : System.Windows.Forms.Button
    {
        public int X;
        public int Y;

        public CellButton(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
