using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.BL
{
    internal class Menu_Item
    {
        private string name;
        private string type;
        private float price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public Menu_Item(string name,int choice,float price)
        {
            this.name = name;
            this.price = price;
            if(choice == 1)
            {
                type = "drink";
            }
            else
            {
                type = "food";
            }
        }
    }
}
