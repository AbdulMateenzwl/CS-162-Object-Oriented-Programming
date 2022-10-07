using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POINT.BL;
namespace POINT
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject gameObject = new GameObject();
         
            while (true)
            {
                Thread.Sleep(100);
                gameObject.Erase();
                gameObject.Move();
                gameObject.Draw();
            }
        }
    }
}
