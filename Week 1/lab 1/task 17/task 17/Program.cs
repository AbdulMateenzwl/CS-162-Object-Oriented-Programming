using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\lab 1\\task 17\\text.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine("Hello World");
            file.Flush();
            file.Close();
        }
    }
}
