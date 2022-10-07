using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
    internal class Ship
    {
        private string name;
        private Angle X;
        private Angle Y;
        public Ship() { }
        public Ship(string name, Angle x, Angle y)
        {
            this.name = name;
            X = x;
            Y = y;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Angle x
        {
            get { return X; }
            set { X = value; }
        }
        public Angle y
        {
            get { return Y; }
            set { Y = value; }
        }
        public void replace(Angle x, Angle y)
        {
            this.X=x;
            this.Y=y;
        }
        
    }
}
