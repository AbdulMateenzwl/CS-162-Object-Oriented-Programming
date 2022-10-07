using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daraz_V_Convert.BL
{
    public class Product
    {
        private string name;
        private int prices;
        private int quantity;
        public string Name { get { return name; } set { name = value; } }
        public int Prices { get { return prices; } set { prices = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
         public Product() { }
        public Product(string name, int prices, int quantity)
        {
            Name = name;
            Prices = prices;
            Quantity = quantity;
        }
    }
}
