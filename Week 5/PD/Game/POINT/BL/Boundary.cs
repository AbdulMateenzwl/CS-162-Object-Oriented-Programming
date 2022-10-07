using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT.BL
{
    class Boundary
    {
        public point TopLeft=new point();
        public point TopRight = new point();
        public point BottomLeft = new point();
        public point BottomRight = new point();
        public Boundary()
        {
            TopLeft.x = 0;
            TopLeft.y = 0;
            TopRight.x = 0;
            TopRight.y = 90;
            BottomLeft.x = 90;
            BottomLeft.y = 0;
            BottomRight.x = 90;
            BottomRight.y = 90;
        }
        public Boundary(point TopLeft, point TopRight, point BottomLeft, point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
        }
    }

}
