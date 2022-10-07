using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;
using ConsoleApp1.DL;

namespace ConsoleApp1.UI
{
    internal class Ship_Ui
    {
        public static Ship take_input()
        {
            Angle input = new Angle();
            Angle input2 = new Angle();
            Console.WriteLine("Enter the Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the X Degree : ");
            input.Degree =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Minute : ");
            input.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Direction : ");
            input.Direction = Console.ReadLine()[0];
            Console.WriteLine("Enter the Y Degree : ");
            input2.Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Minute : ");
            input2.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Direction : ");
            input2.Direction = Console.ReadLine()[0];
            Ship ship = new Ship(name, input, input2);
            return ship;
        }
        public static void position()
        {
            Console.WriteLine("Enter the Name of ship : ");
            string name = Console.ReadLine();
            Ship output = Crud.index(name);
            if (output == null)
            {
                Console.WriteLine("There is no such Ship.");
            }
            else
            {
                display_angle(output);
            }
        }
        public static void serial_num()
        {
            Angle input = new Angle();
            Angle input2 = new Angle();
            Console.WriteLine("Enter the X Degree : ");
            input.Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Minute : ");
            input.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Direction : ");
            input.Direction = Console.ReadLine()[0];
            Console.WriteLine("Enter the Y Degree : ");
            input2.Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Minute : ");
            input2.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Direction : ");
            input2.Direction = Console.ReadLine()[0];
            Ship output = Crud.check_ship(input,input2);
            if(output != null)
            {
                display_name(output);
            }
            else
            {
                Console.WriteLine("There is no such ship.");
            }
        }
        public static void change_position()
        {
            Console.WriteLine("Enter the Name : ");
            string name = Console.ReadLine();
            Ship output = Crud.index(name);
            if (output == null)
            {
                Console.WriteLine("There is no such Ship.");
            }
            else
            {
                Angle input = new Angle();
                Angle input2 = new Angle();
                Console.WriteLine("Enter the X Degree : ");
                input.Degree = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the X Minute : ");
                input.Minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the X Direction : ");
                input.Direction = Console.ReadLine()[0];
                Console.WriteLine("Enter the Y Degree : ");
                input2.Degree = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Y Minute : ");
                input2.Minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Y Direction : ");
                input2.Direction = Console.ReadLine()[0];
                output.replace(input, input2);
                Console.WriteLine("Postion has been changed .");
            }
        }
        public static void display_angle(Ship output)
        {
            Console.WriteLine("Ship is at " + output.x.Degree + "\u00b0" + output.x.Minutes + "'" + output.x.Direction + " and " + output.y.Degree + "\u00b0" + output.y.Minutes + "'" + output.y.Direction);
        }
        public static void display_name(Ship output)
        {
            Console.WriteLine("THe name of the ship is " + output.Name + " .");
        }
    }
}
