using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float length, area;
            string str;
            Console.WriteLine("Enter the length : ");
            str=Console.ReadLine();
            length = float.Parse(str);
            area = length * length;
            Console.WriteLine("The area is :"+ area);
            Console.ReadKey();
        }
    }
}
