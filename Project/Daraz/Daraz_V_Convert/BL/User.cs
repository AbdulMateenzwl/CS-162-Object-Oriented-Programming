using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daraz_V_Convert.DL;
namespace Daraz_V_Convert.BL
{
    public class User
    {
        private string name;
        private string password;
        private string email="";
        private string pin;
        private string phone;
        private List<Product> buy_product = new List<Product>();
        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Pin { get { return pin; } set { pin = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public List<Product> Product { get { return buy_product; } }
        public void add_product_list(Product input)
        {
            buy_product.Add(input);
        }
        public List<Product> get_product_list()
        {
            return buy_product;
        }
        public User() { }
        public User(string name,string password)
        {
            this.name = name;
            this.password = password;
        }   
        
        public User(string names, string pass, string em,string pn,string ph)
        {
            name = names;
            password = pass;
            email=em;
            pin=pn;
            phone=ph;
        }
        public int change_password(string pass, string pass1, string pass2)
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
        
        public void add_product(string name,int index)
        {
            for (int i = 0; i < SellerDL.Seller.Count; i++)
            {
                if (SellerDL.Seller[i].Name==name)
                {
                    buy_product.Add(SellerDL.Seller[i].Products[index]);
                    break;
                }
            }
        }
        public void clear_buyproducts()
        {
            buy_product.Clear();
        }
        public  void add_product(Product p)
        {
            buy_product.Add(p);
        }
    }
}
