using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_sale_app.BL;
using Point_of_sale_app.DL;
namespace Point_of_sale_app.UI
{
    internal class Products_Ui
    {
        public static Products take_input_product()
        {
            Products input = new Products();
            Console.Write("Enter the name of product : ");
            input.Name = Console.ReadLine();
            Console.Write("Enter the Type of product : ");
            input.Type = Console.ReadLine();
            Console.Write("Enter the Price of product : ");
            input.Price = float.Parse(Console.ReadLine());
            Console.Write("Enter the Quantity of product : ");
            input.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minimum Quantity of product : ");
            input.MinQuantity = int.Parse(Console.ReadLine());
            input.cal_tax();
            Console.WriteLine("Product has been added .");
            return input;
        }
        public static void display_products(List<Products> products)
        {
            Console.WriteLine("Name\tPrice\tType\tquanity\tMin.Q");
            Console.WriteLine("");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].Name + "\t" + products[i].Price + "\t" + products[i].Type + "\t" + products[i].Quantity + "\t" + products[i].MinQuantity);
            }
        }
        public static void display_highest(Products products)
        {
            Console.WriteLine("Name\tPrice\tType\tquanity\tMin.Q\tTax");
            Console.WriteLine("");
            Console.WriteLine(products.Name + "\t" + products.Price + "\t" + products.Type + "\t" + products.Quantity + "\t" + products.MinQuantity + "\t" + products.Tax);
        }
        public static void display_taxes(List<Products> products)
        {
            Console.WriteLine("Name\tPrice\tTax");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].Name + "\t" + products[i].Price + "\t" + products[i].Tax);
            }
        }
        public static void to_order(List<Products> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Quantity < products[i].MinQuantity)
                {
                    Console.WriteLine("You have to order " + products[i].Name);
                }
            }
        }
        public static void invoice(float total)
        {
            Console.WriteLine("Your Total is " + total);
        }
        
    }
}
