using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop.BL
{
    internal class Coffee_shop
    {
        public string name;
        public List<Menu_Item> items=new List<Menu_Item>();
        public List<Menu_Item> orders=new List<Menu_Item>();
        public Coffee_shop() { }
        public Coffee_shop(string name)
        {
            this.name = name;
        }
        public void Add_items(Menu_Item input)
        {
            items.Add(input);
        }
        public void Add_orders(Menu_Item input)
        {
            orders.Add(input);
        }
    }
}
