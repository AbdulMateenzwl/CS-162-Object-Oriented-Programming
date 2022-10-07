using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.BL;
using Tasks.DL;
namespace Tasks.UI
{
    internal class Ui
    {
        public static point get_point()
        {
            point input = new point();
            Console.WriteLine("Enter the X Cordinate");
            input.setX(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the Y Cordinate");
            input.setY(int.Parse(Console.ReadLine()));
            return input;
        }
        public static void display_point(point pt)
        {
            Console.WriteLine("X Cordinate = " + pt.getX());
            Console.WriteLine("Y Cordinate = " + pt.getY());
        }
        public static void display_length()
        {
            Console.WriteLine("Length of line = " + Crud.get_line().get_length());
        }
        public static void display_gradiant()
        {
            Console.WriteLine("Gradiant of line = " + Crud.get_line().gradiant());
        }
        public static void distace_start_from_zero()
        {
            Console.WriteLine("Distance from Begin point = " + Crud.get_line().get_start().distance_zero());
        }
        public static void distance_end_from_zero()
        {
            Console.WriteLine("Distance from End point = " + Crud.get_line().get_end().distance_zero());
        }
    }
}
