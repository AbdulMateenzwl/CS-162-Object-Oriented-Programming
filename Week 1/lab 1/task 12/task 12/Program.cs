using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Enter Number :");
            num = int.Parse(Console.ReadLine());
            while(num != -1)
            {
                sum += num;
                Console.WriteLine("Enter Number :");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Total = " + sum);
            Console.ReadKey();
        }
    }
}
