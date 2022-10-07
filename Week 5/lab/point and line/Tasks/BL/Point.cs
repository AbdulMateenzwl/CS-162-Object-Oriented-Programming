using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.BL
{
    internal class point
    {
        private int X;
        private int Y;
        public point() { }
        public point(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public void setX(int X)
        {
            this.X = X;
        }
        public void setY(int Y)
        {
            this.Y = Y;
        }
        public void setXY(int x,int y)
        {
            X = x;
            Y = y;
        }

        public double distance(int x1,int y1,int x2,int y2)
        {
            double ans = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
            return ans;
        }
        public double distance_cord(int x,int y)
        {
            return distance(X, Y, x, y);
        }
        public double distance_zero()
        {
            return distance(X, Y, 0, 0);
        }
        public double distance_point(point pt)
        {
            return distance(X, Y, pt.X, pt.Y);
        }
    }
}
