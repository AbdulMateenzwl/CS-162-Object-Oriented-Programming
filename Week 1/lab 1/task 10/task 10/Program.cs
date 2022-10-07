using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter your Marks : ");
            str=Console.ReadLine();
            float num = float.Parse(str);
            if(num > 50)
            {
                Console.WriteLine("You are passed");
            }
            else
            {
                Console.WriteLine("You are failed");
            }
            Console.ReadKey();
        }
    }
}
