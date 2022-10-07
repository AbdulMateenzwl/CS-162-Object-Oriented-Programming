using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daraz_V_Convert.BL;
using System.IO;
using Daraz_V_Convert.Forms;
namespace Daraz_V_Convert.DL
{
    class SellerDL
    {
        static string path = "seller.txt";
        private static List<Seller> seller = new List<Seller>();
        public static List<Seller> Seller { get { return seller; } }
        public static void add_list(Seller input)
        {
            seller.Add(input);
        }
        public static List<Seller> get_list()
        {
            return seller;
        }
        public static Seller get_seller(string seller_name,string pass)
        {
            for (int i = 0; i < seller.Count; i++)
            {
                if (seller_name == seller[i].Name && pass == seller[i].Password)
                {
                    return seller[i];
                }
            }
            return null;
        }
        public static Seller get_seller(string seller_name)
        {
            for (int i = 0; i < seller.Count; i++)
            {
                if (seller_name == seller[i].Name)
                {
                    return seller[i];
                }
            }
            return null;
        }
        public static void replace(Seller pre,Seller nw)
        {
            for (int i = 0; i < seller.Count; i++)
            {
                if (pre.Name == Seller[i].Name && pre.Buisness == Seller[i].Buisness && pre.PhoneNum == Seller[i].PhoneNum && pre.Password == Seller[i].Password)
                {
                    Seller[i]= nw;
                }
            }
        }
        public static void delete(int index)
        {
            seller.RemoveAt(index);
        }
        public static List<Product> get_products(string name)
        {
            for (int i = 0; i < seller.Count; i++)
            {
                if (name == seller[i].Name)
                {
                    return seller[i].Products;
                }
            }
            return null;
        }
        
        public static void store_data()
        {
            StreamWriter var = new StreamWriter(path, false);
            for (int i = 0; i < seller.Count; i++)
            {
                var.Write(seller[i].Name + "," + seller[i].PhoneNum + "," + seller[i].Buisness + "," + seller[i].Password + "," + seller[i].Products.Count+",");
                
                for (int m = 0; m < seller[i].Products.Count; m++)
                {
                    var.Write(seller[i].Products[m].Name + ";" + seller[i].Products[m].Prices + ";" + seller[i].Products[m].Quantity); 
                    if(m!= seller[i].Products.Count-1)
                    {
                        var.Write("$");
                    }
                }
                var.WriteLine("");
            }
            var.Close();
        }
        public static void loadData()
        {
            string path = "seller.txt";
            if (File.Exists(path))
            {
                StreamReader var = new StreamReader(path);
                string record;
                while ((record = var.ReadLine()) != null)
                {
                    string[] splitData = record.Split(',');
                    Seller s = new Seller();
                    s.Name = splitData[0];
                    s.PhoneNum = splitData[1];
                    s.Buisness = splitData[2];
                    s.Password = splitData[3];
                    int count = int.Parse(splitData[4]);
                    string list = splitData[5];
                    string[] splitList = list.Split('$');
                    for (int i = 0; i < count; i++)
                    {
                        string pline = splitList[i];
                        string[] po = pline.Split(';');
                        Product p = new Product();
                        p.Name = po[0];
                        p.Prices = int.Parse(po[1]);
                        p.Quantity = int.Parse(po[2]);
                        s.add_product(p);
                    }
                    seller.Add(s);
                }
                var.Close();
            }
        }
    }
}
