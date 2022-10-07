using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.BL
{
    internal class Cell
    {
        private int x;
        private int y;
        private char val;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public char Value { get { return val; } set { val = value; } }
        public Cell(char value,int x,int y)
        {
            this.x = x;
            this.y = y;
            this.val = value;
        }
        public bool IsPacmanPresent()
        {
            if (val == 'P')
            {
                return true;
            }
            return false;
        }
        public bool IsGhostPresent(char ghostChar)
        {
            if (val == ghostChar)
            {
                return true;
            }
            return false;
        }
    }
}
