using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter the number = ");
                num[i] = int.Parse(Console.ReadLine());
            }
            int largest = -99;
            for (int i = 0; i < 3; i++)
            {
                if(largest < num[i])
                {
                    largest = num[i];
                }
            }
            Console.WriteLine("Largest = "+ largest);
            Console.ReadKey();
        }
    }
}
