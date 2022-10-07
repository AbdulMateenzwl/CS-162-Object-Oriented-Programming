using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Shop.BL;
using Coffee_Shop.DL;
namespace Coffee_Shop.UI
{
    internal class Ui
    {
        
        public static Menu_Item add_Order()
        {
            Console.Write("Enter the name of Product : ");
            string name = Console.ReadLine();
            Menu_Item input=Crud_menu.give_index(name);
            if(input == null)
            {
                Console.WriteLine("The Product Is not available .");
            }
            else
            {
                Console.WriteLine("Item has been ordered .");
                return input;  
            }
            return null;
        }
        public static void show_drinks(List<Menu_Item> items)
        {
            Console.WriteLine("Name\tPrice");
            for (int i = 0; i < items.Count; i++)
            {
                if( items[i].Type =="drink")
                {
                    Console.WriteLine(items[i].Name+"\t"+items[i].Price);
                }
            }
        }
        public static void show_food(List<Menu_Item> items)
        {
            Console.WriteLine("Name\tPrice");
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Type == "food")
                {
                    Console.WriteLine(items[i].Name + "\t" + items[i].Price);
                }
            }
        }
        public static void display_all(List<Menu_Item> items)
        {
            Console.WriteLine("Name\tPrice");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Name+"\t"+ items[i].Price);
            }
        }
        public static void display_minimum(Menu_Item min)
        {
            if(min != null)
            {
                Console.WriteLine("The Item with minimum Price "+min.Price+" is "+min.Name+" .");
            }
            else
            {
                Console.WriteLine("There are no Products .");
            }
        }
        public static void show_orders()
        {
            if(Crud_menu.check_orders())
            {
                Console.WriteLine("The Item is ready .");
                Crud_menu.coffee_shop.orders.Clear();
            }
            else
            {
                Console.WriteLine("All the orders have been fulfiled .");
            }
        }
        public static void display_orders(List<Menu_Item> orders)
        {
            Console.WriteLine("Name\tPrice");
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine(orders[i].Name+"\t"+orders[i].Price);
            }
        }
        public static void display_total(float total)
        {
            Console.WriteLine("The total amount is "+total+" .");
        }
        
    }
}
