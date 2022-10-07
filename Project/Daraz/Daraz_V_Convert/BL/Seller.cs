using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daraz_V_Convert.BL
{
    public class Seller
    {
        private string name;
        private string phone_num;
        private string buisness;
        private string password;
        private List<Product> product=new List<Product>();
        public string Name{get { return name; } set { name = value; } }
        public string PhoneNum{get { return phone_num; } set { phone_num = value; } }
        public string Buisness{get { return buisness; } set { buisness = value; } }
        public string Password{get { return password; } set { password = value; } }
        public List<Product> Products { get { return product; } }
        public Seller() { }
        public Seller(string names,string ph,string buiss,string pass)
        {
            name=names;
            phone_num=ph;
            buisness=buiss;
            password=pass;
        }

        public void add_product(Product input)
        {
            product.Add(input);
        }
        public List<Product> get_product_list()
        {
            return product;
        }
        public Product check_product(string name)
        {
            for (int i = 0; i < product.Count; i++)
            {
                if (name == product[i].Name)
                {
                    return product[i];
                }
            }
            return null;
        }
        public  int change_password(string pass, string pass1, string pass2)
        {
            if (pass == this.Password)
            {
                if (pass1 == pass)
                {
                    return 2;
                }
                else
                {
                    if (pass1 == pass2)
                    {
                        this.Password = pass1;
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
            else
            {
                return 1;
            }
        }
        public void replace_product(Product pre,Product nw)
        {
            for (int i = 0; i < product.Count; i++)
            {
                if(product[i].Name==pre.Name && product[i].Prices==pre.Prices && product[i].Quantity==pre.Quantity)
                {
                    product[i] = nw;
                    break;
                }
            }
        }
        public void delete_product(int index)
        {
            product.RemoveAt(index);
        }
        public bool decrement(Product a)
        {
            for (int i = 0; i < product.Count; i++)
            {
                if (product[i]==a)
                {
                    if(a.Quantity>=1)
                    {
                        a.Quantity--;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
