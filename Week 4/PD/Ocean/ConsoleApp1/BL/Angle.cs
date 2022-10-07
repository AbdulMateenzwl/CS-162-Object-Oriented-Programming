using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
    internal class Angle
    {
        private int degree;
        private float minutes;
        private char direction;
        public int Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        public float Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }
        public char Direction
        {
            get { return this.direction; }
            set { this.direction = value; }
        }
    }
}
