using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UI
{
    internal class Menu_Ui
    {
        public static char menu()
        {
            Console.WriteLine("1) Add Ship");
            Console.WriteLine("2) View Ship Position");
            Console.WriteLine("3) View Ship Serial Number");
            Console.WriteLine("4) Change Ship Position");
            Console.WriteLine("5) Exit");
            char ch = Console.ReadLine()[0];
            return ch;
        }
    }
}
