using Point_of_sale_app.BL;
using System.Collections.Generic;

namespace Point_of_sale_app.DL
{
    internal class User_Dl
    {
        public static List<User> users = new List<User>();
        public static int if_exists(User chk)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name == chk.Name &&users[i].Password == chk.Password  && users[i].Role == "Admin")
                {
                    return 1;
                }
                else if (users[i].Name == chk.Name && users[i].Password == chk.Password && users[i].Role == "Customer")
                {
                    return 2;
                }
            }
            return 3;
        }
        public static void ADD_User(User input)
        {
            users.Add(input);
        }
        public static User take_user(User chk)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if(users[i].Name == chk.Name && users[i].Password == chk.Password)
                {
                    return users[i];
                }
            }
            return null;
        }
    }
}