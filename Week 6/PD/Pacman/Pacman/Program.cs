using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman.BL;
namespace Pacman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "maze.txt";
            Grid maze = new Grid(24, 71, path);



            maze.draw();



            Console.ReadKey();
        }
    }
}
