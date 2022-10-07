using Point_of_sale_app.BL;
using Point_of_sale_app.DL;
using Point_of_sale_app.UI;
using System;

namespace Point_of_sale_app
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User first = new User("1", "1","1");
            User_Dl.ADD_User(first);
            while (true)
            {
                char option = Menu_Ui.menu();
                if (option == '1')
                {
                    User_Dl.ADD_User(User_Ui.take_input_user());
                    Console.WriteLine("Account created .");
                }
                else if (option == '2')
                {
                    User user = User_Ui.take_input_user();
                    int chk = User_Dl.if_exists(user);
                    if (chk == 1)
                    {
                        while (true)
                        {
                            char op = Menu_Ui.admin_menu();
                            if (op == '1')
                            {
                                Products_Dl.ADD_Product(Products_Ui.take_input_product());
                            }
                            else if (op == '2')
                            {
                                Products_Ui.display_products(Products_Dl.get_products());
                            }
                            else if (op == '3')
                            {
                                Products_Ui.display_highest(Products_Dl.get_highest());
                            }
                            else if (op == '4')
                            {
                                Products_Ui.display_taxes(Products_Dl.get_products());
                            }
                            else if (op == '5')
                            {
                                Products_Ui.to_order(Products_Dl.get_products());
                            }
                            else
                            {
                                break;
                            }
                            Console.ReadKey();
                        }
                    }
                    if (chk == 2)
                    {
                        User user_in_charge = User_Dl.take_user(user);
                        while (true)
                        {
                            char op = Menu_Ui.cust_menu();
                            if(op=='1')
                            {
                                Products_Ui.display_products(Products_Dl.get_products());
                            }
                            else if(op=='2')
                            {
                                Products_Ui.display_products(Products_Dl.products);
                                User_Ui.buy_product(Products_Dl.get_products(),user_in_charge.get_buyproducts());
                            }
                            else if(op=='3')
                            {
                                User_Ui.display_orders(user_in_charge.get_buyproducts());
                                Products_Ui.invoice(user_in_charge.cal_total());
                            }
                            else
                            {
                                break;
                            }
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Account does not exists...");
                    }
                }
                else if (option == '3')
                {
                    break;
                }
                Menu_Ui.clear_screen();
            }
        }
    }
}