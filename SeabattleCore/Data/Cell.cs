using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Seabattle.Data
{
    public class Cell
    {
        [XmlAttribute(AttributeName ="x")]
        public int X;

        [XmlAttribute(AttributeName = "y")]
        public int Y;

        public State CellState;

        public Cell() { }
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool CheckAround(int x, int y)
        {
            int dist = Math.Max(Math.Abs(X - x), Math.Abs(Y - y));
            return dist > 1;
        }

        public bool CheckNear(int x, int y)
        {
            int dist = Math.Abs(X - x) + Math.Abs(Y - y);
            return dist == 1;
        }
    }
    
}
