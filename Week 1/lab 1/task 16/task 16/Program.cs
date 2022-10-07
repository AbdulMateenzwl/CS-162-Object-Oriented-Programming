using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16
{
    class Program
    {
        static int add(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int num2 = int.Parse(Console.ReadLine());
            int ans = add(num1, num2);
            Console.WriteLine("Sum = "+ ans);
            Console.ReadKey();
        }
    }
}
