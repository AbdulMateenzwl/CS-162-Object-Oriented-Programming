using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cal.BL
{
    internal class Operation
    {
        public static double operate(double n1,double n2,char op)
        {
            if(op=='+')
            {
                return n1 + n2;
            }
            else if(op=='-')
            {
                return n1 - n2;
            }
            else if(op=='/')
            {
                return n1 / n2;
            }
            else if(op=='*')
            {
                return n1 * n2;
            }
            return 0;
        }
    }
}
