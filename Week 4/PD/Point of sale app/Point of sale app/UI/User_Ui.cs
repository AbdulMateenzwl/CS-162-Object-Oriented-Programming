using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_sale_app.BL;
using Point_of_sale_app.DL;
namespace Point_of_sale_app.UI
{
    internal class User_Ui
    {
        public static User take_input_user()
        {
            Console.WriteLine("Enter your name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter your Password : ");
            string password = Console.ReadLine();
            User input = new User(Name, password);
            return input;
        }
        public static void buy_product(List<Products> products, List<Products> buyproducts)
        {
            Console.WriteLine("Enter the name product : ");
            string name = Console.ReadLine();
            int index = Products_Dl.check_buyproduct(name);
            if (index != -1)
            {
                bool chk = products[index].minus_quanitity();
                buyproducts.Add(products[index]);
                Console.WriteLine("Product has been added successfully .");
            }
            else
            {
                Console.WriteLine("Product Does not exist .");
            }
        }
        public static void display_orders(List<Products> orders)
        {
            Console.WriteLine("Name\tPrice\tTax");
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine(orders[i].Name + "\t" + orders[i].Price + "\t" + orders[i].Tax);
            }
        }
    }
}
