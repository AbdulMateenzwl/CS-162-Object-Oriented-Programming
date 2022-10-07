using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int sum = 0;
            Console.WriteLine("Enter Number : ");
            str=Console.ReadLine();
            int num = int.Parse(str);
            do
            {
                sum = sum + num;
                Console.WriteLine("Enter Number : ");
                str = Console.ReadLine();
                num = int.Parse(str);
            }
            while (num != -1);
            Console.WriteLine("Total =  " + sum);
            Console.ReadKey();
        }
    }
}
