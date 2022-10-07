using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Daraz_V_Convert.BL;
namespace Daraz_V_Convert.DL
{
    class UserDL
    {
        public static string path="user.txt";
        private static List<User> users= new List<User>();
        public static void add_list(User input)
        {
            users.Add(input);
        }
        public static List<User> get_list()
        {
            return users;
        }
        public static User get_user(string name,string pass)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (name == users[i].Name && users[i].Password==pass)
                {
                    return users[i];
                }
            }
            return null;
        }
        public static void store_data()
        {
            StreamWriter var = new StreamWriter(path, false);
            for (int i = 0; i < users.Count; i++)
            {
                var.Write(users[i].Name + "," + users[i].Password + "," + users[i].Product.Count+",");

                for (int m = 0; m < users[i].Product.Count; m++)
                {
                    var.Write(users[i].Product[m].Name + ";" + users[i].Product[m].Prices + ";" + users[i].Product[m].Quantity);
                    if (m != users[i].Product.Count - 1)
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
            if (File.Exists(path))
            {
                StreamReader var = new StreamReader(path);
                string record;
                while ((record = var.ReadLine()) != null)
                {
                    string[] splitData = record.Split(',');
                    User s = new User();
                    s.Name = splitData[0];
                    s.Password = splitData[1];
                    int count = int.Parse(splitData[2]);
                    string list = splitData[3];
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
                    users.Add(s);
                }
                var.Close();
            }
        }
    }
}
