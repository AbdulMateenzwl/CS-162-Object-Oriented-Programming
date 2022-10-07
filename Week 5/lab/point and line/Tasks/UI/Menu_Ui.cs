using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.UI
{
    internal class Menu_Ui
    {
        public static char menu()
        {
            Console.Clear();
            Console.WriteLine("/////////////////////   Menu   //////////////////////////");
            Console.WriteLine("");
            Console.WriteLine("1) Make a line");
            Console.WriteLine("2) Update begin Point");
            Console.WriteLine("3) Update end point");
            Console.WriteLine("4) Show start point");
            Console.WriteLine("5) Show end point");
            Console.WriteLine("6) Get Length");
            Console.WriteLine("7) Get Gradiant");
            Console.WriteLine("8) Get distance of begin point from zero");
            Console.WriteLine("9) Get distance of end point from Zero");
            Console.WriteLine("0) EXIT");
            char ch = char.Parse(Console.ReadLine());
            return ch;
        }
        public static void confirm_option()
        {
            Console.Write("Press to Continue...");
            Console.ReadKey();
        }


    }
}
