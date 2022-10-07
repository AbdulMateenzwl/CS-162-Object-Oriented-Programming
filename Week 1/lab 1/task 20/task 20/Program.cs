using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int even = 10;
            Console.WriteLine("Enter Lilly Age :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price of each Toy :");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price of Machine :");
            int Machine = int.Parse(Console.ReadLine());
            for (int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    total = total + even;
                    even = even + 10;
                    total = total - 1;
                }
                else
                {
                    total = total + P;
                }
            }
            if(total > Machine)
            {
                Console.WriteLine(true);
                Console.Write("Remaining is ");
                Console.WriteLine(Machine-total);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
    }
}
