using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.BL
{
    internal class line
    {
        private point P1=new point();
        private point P2=new point();
        public line() { }
        public line(point p1,point p2)
        {
            this.P1=p1;
            this.P2=p2;
        }
        public void set_start(point p1)
        {
            this.P1 = p1;
        }
        public void set_end(point p2)
        {
            this.P2= p2;
        }
        public point get_start()
        {
            return P1;
        }
        public point get_end()
        {
            return P2;
        }
        public double get_length()
        {
            return P1.distance_point(P2);
        }
        public double gradiant()
        {
            return (P2.getY() - P1.getY()) / (P2.getX() - P1.getX());
        }
    }
}
