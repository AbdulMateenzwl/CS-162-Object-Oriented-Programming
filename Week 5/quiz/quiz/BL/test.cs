using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.BL
{
    internal class test
    {
        public int tile_cost;
        public int installation_cost;
        public int polishing_cost;
        public double total;
        public test() { }
        public test(int t1, int t2, int t3)
        {
            tile_cost = t1;
            installation_cost = t2;
            polishing_cost = t3;
        }
        public void cal_total()
        {
            total = tile_cost + installation_cost + polishing_cost;
        }
    }
}
