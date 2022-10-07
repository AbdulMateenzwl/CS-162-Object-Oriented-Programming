using System.Collections.Generic;

namespace Point_of_sale_app.BL
{
    internal class User
    {
        private string name;
        private string role;
        private string password;
        private List<Products> buy_products = new List<Products>();

        public User()
        { }
        public User(string name, string pass, string rolee)
        {
            this.name = name;
            this.password = pass;
            if (rolee == "1")
            {
                this.role = "Admin";
            }
            else
            {
                this.role = "Customer";
            }
        }
        public User(string name, string pass)
        {
            this.name = name;
            this.password = pass;
            this.role = "Customer";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public void ADD_buyproduct(Products input)
        {
            buy_products.Add(input);
        }
        public List<Products> get_buyproducts()
        {
            return buy_products;
        }
        public float cal_total()
        {
            float total = 0;
            for (int i = 0; i < buy_products.Count; i++)
            {
                total = total + buy_products[i].Price;
            }
            return total;
        }
    }
}