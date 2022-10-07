using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\lab 1\\task 17\\text.txt";
            if(File.Exists(path))
            {
                StreamReader var = new StreamReader(path);
                string str;
                while (  (str = var.ReadLine()) != null )
                {
                    Console.WriteLine(str);
                }
                var.Close();
            }
            else
            {
                Console.WriteLine("File Does not exists");
            }
        }
    }
}
