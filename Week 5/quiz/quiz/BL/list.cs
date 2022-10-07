using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.BL;
namespace quiz.BL
{
    internal class list
    {
        public test marble;
        public test granite;
        public list() { }
        public list(int t1, int t2, int t3, int t4, int t5, int t6)
        {
            marble=new test(t1,t2,t3);
            granite=new test(t4,t5,t6);
        }
        public void total()
        {
            marble.cal_total();
            granite.cal_total();
        }
    }
}
