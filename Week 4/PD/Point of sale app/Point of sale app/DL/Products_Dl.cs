using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_sale_app.BL;

namespace Point_of_sale_app.DL
{
    internal class Products_Dl
    {
        public static List<Products> products = new List<Products>();
        public static void ADD_Product(Products input)
        {
            products.Add(input);
        }
        public static List<Products> get_products()
        {
            return products;
        }
        public static Products get_highest()
        {
            int index = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price > products[index].Price)
                {
                    index = i;
                }
            }
            return products[index];
        }
        public static int check_buyproduct(string str)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == str)
                {
                    return i;
                }
            }
            return -1;
        }
       

    }
}
