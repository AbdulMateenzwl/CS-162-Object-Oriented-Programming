using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\lab 1\\task 21\\1.txt";
            Console.WriteLine("1) Sign In");
            Console.WriteLine("2) Sign Up");
            string op = Console.ReadLine();
            if(op == "1")
            {
                signin(path);
            }
            else if(op == "2")
            {
                signup(path);
            }
            Console.WriteLine("gf");
            Console.ReadKey();
        }
        static void signin(string path)
        {
            Console.WriteLine("Enter your name :");
            string name =Console.ReadLine();
            Console.WriteLine("Enter your Password :");
            string pass = Console.ReadLine();
            StreamWriter wrt = new StreamWriter(path, true);
            wrt.WriteLine(name + "," + pass);
            wrt.Flush();
            wrt.Close();
        }
        static void signup(string path)
        {
            bool check = false;
            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Password :");
            string pass = Console.ReadLine();
            StreamReader red = new StreamReader(path);
            string line;
            while (!red.EndOfStream)
            {
                line = red.ReadLine();
                string name1 = parse1(line, 1);
                string pass1 = parse1(line, 2);
                if(name == name1 && pass == pass1)
                {
                    check = true;
                    break;
                }
                
            }
            
            if (check)
            {
                Console.WriteLine("Welcome "+name);
            }
            else
            {
                Console.WriteLine("User not found");
            }
            red.Close();
        }
        static string parse1(string str,int col)
        {
            string str2="";
            int commaCount = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == ',')
                {
                    commaCount++;
                }
                else if(col == commaCount)
                {
                    str2 = str2 + str[i];
                }
            }
            return str2;
        }
    }
}
