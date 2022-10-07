using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_22
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static string parse1(string str, int col)
        {
            string str2 = "";
            int commaCount = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',')
                {
                    commaCount++;
                }
                else if (col == commaCount)
                {
                    str2 = str2 + str[i];
                }
            }
            return str2;
        }
    }
}
