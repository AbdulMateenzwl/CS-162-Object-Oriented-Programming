using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.BL;

namespace quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            list stones = new list(300,80,10,400,90,15);
            stones.total();
            Console.WriteLine("Marble cost per square meter : "+stones.marble.total);
            Console.WriteLine("Granite cost per square meter : " + stones.granite.total);
            Console.ReadKey();
        }
    }
}
