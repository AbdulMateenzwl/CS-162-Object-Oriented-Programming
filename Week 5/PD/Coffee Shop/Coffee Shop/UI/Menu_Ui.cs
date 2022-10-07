using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.UI
{
    internal class Menu_Ui
    {
        public static char menu()
        {
            Console.WriteLine("1) Add Menu Item");
            Console.WriteLine("2) View the cheapest item in the Menu");
            Console.WriteLine("3) View the Drinks Menu");
            Console.WriteLine("4) View the Food Menu");
            Console.WriteLine("5) Add Order");
            Console.WriteLine("6) Fulfil the Order");
            Console.WriteLine("7) View the orders list");
            Console.WriteLine("8) Total Payable Amount");
            Console.WriteLine("9) EXIT");
            Console.Write("Enter any option ...");
            char op = Console.ReadLine()[0];
            return op;
        }
        public static void clear_screen()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
