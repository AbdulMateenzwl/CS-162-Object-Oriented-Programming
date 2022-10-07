using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;

namespace ConsoleApp1.DL
{
    internal class Crud
    {
        public static List<Ship> ship_list = new List<Ship>();
        public static Ship index(string name)
        {
            for (int i = 0; i < ship_list.Count; i++)
            {
                if (name == ship_list[i].Name)
                {
                    return ship_list[i];
                }
            }
            return null;
        }
        public static Ship check_ship(Angle x,Angle y)
        {
            for (int i = 0; i < ship_list.Count; i++)
            {
                if (x.Degree == ship_list[i].x.Degree && y.Degree==ship_list[i].y.Degree && x.Minutes == ship_list[i].x.Minutes && y.Minutes == ship_list[i].y.Minutes && x.Direction == ship_list[i].x.Direction && y.Direction == ship_list[i].y.Direction)
                {
                    return ship_list[i];
                }
            }
            return null;
        }
        public static void add_ship(Ship input)
        {
            ship_list.Add(input);
        }
    }
}
