using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_sale_app.UI
{
    internal class Menu_Ui
    {
        public static char menu()
        {
            Console.Clear();
            Console.WriteLine("1) Sign UP");
            Console.WriteLine("2) Sign IN");
            Console.WriteLine("EXIT");
            Console.Write("Enter any option...");
            char op = Console.ReadLine()[0];
            return op;
        }
        public static void clear_screen()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static char cust_menu()
        {
            Console.Clear();
            Console.WriteLine("1) View All produtcs");
            Console.WriteLine("2) Buy Product");
            Console.WriteLine("3) Generate invoice");
            Console.WriteLine("4) EXIT");
            char op = Console.ReadLine()[0];
            return op;
        }
        public static char admin_menu()
        {
            Console.Clear();
            Console.WriteLine("////////////         ADMIN MENU        ///////////////////");
            Console.WriteLine("");
            Console.WriteLine("1) Add Products");
            Console.WriteLine("2) View All products");
            Console.WriteLine("3) Find Products with the highest price");
            Console.WriteLine("4) View sales tax on all products");
            Console.WriteLine("5) Products to be Ordered");
            Console.WriteLine("6) EXIT");
            char op = Console.ReadLine()[0];
            return op;
        }

    }
}
