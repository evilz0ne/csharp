using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeabattleWeb
{
    public class CellButton: System.Web.UI.WebControls.Button
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