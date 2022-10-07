using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POINT.BL;
namespace POINT.UI
{
    class Ui
    {
        public static void draw_shap(char[,] shape,point boundary)
        {
            int m = 0;int n = 0;
            for(int i=boundary.getX(); i < (boundary.getX()+ shape.GetLength(0)); i++)
            {
                n = 0;
                for(int j=boundary.getY(); j< (boundary.getY() + shape.GetLength(1)); j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(shape[m,n]);
                    n++;
                }
                m++;
                Console.WriteLine();
            }
        }
        public static void erase_shape(char[,] shape, point boundary)
        {
            int m = 0; int n = 0;
            for (int i = boundary.getX(); i < (boundary.getX() + shape.GetLength(0)); i++)
            {
                n = 0;
                for (int j = boundary.getY(); j < (boundary.getY() + shape.GetLength(1)); j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write(" ");
                    n++;
                }
                m++;
                Console.WriteLine();
            }
        }
    }
}
