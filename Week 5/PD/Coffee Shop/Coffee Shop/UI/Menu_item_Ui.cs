using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Shop.BL;
using Coffee_Shop.DL;
namespace Coffee_Shop.UI
{
    internal class Menu_item_Ui
    {
        public static Menu_Item Add_item()
        {
            Console.WriteLine("Enter the name of Item : ");
            string name = Console.ReadLine();
            Console.WriteLine("1) Drink");
            Console.WriteLine("2) Food");
            Console.Write("Enter the type of item : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter the price : ");
            float price = float.Parse(Console.ReadLine());
            Menu_Item input = new Menu_Item(name, choice, price);
            return input;
        }
    }
}
