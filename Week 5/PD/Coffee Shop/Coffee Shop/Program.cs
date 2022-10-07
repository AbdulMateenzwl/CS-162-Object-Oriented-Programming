using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Shop.UI;
using Coffee_Shop.BL;
using Coffee_Shop.DL;
namespace Coffee_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                char op = Menu_Ui.menu();
                if(op=='1')
                {
                    Crud_menu.add_item(Menu_item_Ui.Add_item());
                }
                else if(op=='2')
                {
                    Ui.display_minimum(Crud_menu.Cheapest());
                }
                else if(op=='3')
                {
                    Ui.show_drinks(Crud_menu.get_items());
                }
                else if(op=='4')
                {
                    Ui.show_food(Crud_menu.get_items());
                }
                else if(op=='5')
                {
                    Ui.display_all(Crud_menu.get_items());
                    Menu_Item order;
                    if ((order = Ui.add_Order()) != null)
                    {
                        Crud_menu.add_order(order);
                    }
                }
                else if(op=='6')
                {
                    Ui.show_orders();
                }
                else if(op=='7')
                {
                    Ui.display_orders(Crud_menu.get_orders());
                }
                else if(op=='8')
                {
                    Ui.display_total(Crud_menu.get_total());
                    Crud_menu.coffee_shop.orders.Clear();
                }
                else if(op=='9')
                {
                    break;
                }
                Menu_Ui.clear_screen();
            }
        }
        
    }
}
