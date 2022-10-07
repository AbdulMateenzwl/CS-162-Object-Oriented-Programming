using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tasks.jk;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test test = new test();
            Console.Write("Empty Time :> ");
            test.print_time();
            test test1 = new test(8);
            Console.Write("Empty Time :> ");
            test1.print_time();
            test test2 = new test(8,30);
            Console.Write("Empty Time :> ");
            test2.print_time();
            test test3 = new test(8,30,55);
            Console.Write("Empty Time :> ");
            test3.print_time();
            test3.increment_hours();
            Console.Write("Time :> ");
            test3.print_time();
            test3.increment_min();
            Console.Write("Time :> ");
            test3.print_time();
            test3.increment_sec();
            Console.Write("Time :> ");
            test3.print_time();
            bool flag=test3.is_equal(3,40, 55);
            Console.WriteLine("Flag :> "+flag);
            test clk = new test(9,31,56);
            flag = test3.is_equal(clk);
            Console.WriteLine("Flag :> " + flag);
            test3.in_sec();
            test2.rem_in_sec();
            Console.WriteLine("/////////////////////////////////////////////////");
            Console.WriteLine("Enter Hours");
            int h=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minutes");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seconds");
            int s = int.Parse(Console.ReadLine());
            test test4 = new test(h,m,s);
            Console.WriteLine("Enter Hours");
            int h1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minutes");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seconds");
            int s1 = int.Parse(Console.ReadLine());
            test test5=new test(h1,m1,s1);
            test.distance(test4, test5);
            Console.ReadKey();
        }
    }
}
