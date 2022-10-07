using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Daraz_V_Convert.BL;
namespace Daraz_V_Convert.DL
{
    class AdminDL
    {
        private static string path = "Admin.txt";
        private static Admin admin = new Admin();
        public static Admin Admin { get { return admin; } set { admin = value;} }
        public static Admin get_admin(string name, string pass)
        {
            if (name == admin.Username && admin.Password == pass)
            {
                return admin;
            }
            else
            {
                return null;
            }
        }
        public static int change_password(string pass,string pass1,string pass2)
        {
            if(pass==admin.Password)
            {
                if(pass1==pass)
                {
                    return 2;
                }
                else
                {
                    if(pass1==pass2)
                    {
                        admin.Password = pass1;
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
        public static void load_data()
        {
            StreamReader a = new StreamReader(path);
            admin.Username= a.ReadLine();
            admin.Password = a.ReadLine();
            a.Close();
        }
        public static void store_data()
        {
            StreamWriter a = new StreamWriter(path, false);
            a.WriteLine(Admin.Username);
            a.WriteLine(Admin.Password);
            a.Flush();
        }
    }
}
