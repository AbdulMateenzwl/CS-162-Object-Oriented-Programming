using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        
        class stu
        {
            public string name;
            public int roll_no;
            public float cgpa;
        }

        static int count = 0;
        static void Main(string[] args)
        {
            int size = 0;
            Console.WriteLine("Enter the size :");
            stu[] student = new stu[int.Parse(Console.ReadLine())];
            Console.Clear();
            char op = Menu();
            if(op=='1')
            {
                student[count] = add();
            }
            else if(op=='2')
            {
                for (int i = 0; i < size; i++)
                {
                    display(student[i]);
                }
            }
            else if(op=='3')
            {

            }
            else if(op=='4')
            {
                
            }
            else
            {
                Console.WriteLine("You have entered the wrong input .");
            }
            Console.ReadKey();
        }
        static stu add()
        {
            stu s = new stu();
            Console.WriteLine("Enter your name : ");
            s.name = Console.ReadLine();
            Console.WriteLine("Enter your roll no : ");
            s.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your cgpa : ");
            s.cgpa = float.Parse(Console.ReadLine());
            count++;
            return s;
        }
        static void display(stu s)
        {
            Console.WriteLine(s.name + "  " + s.roll_no + "  " + s.cgpa);
        }
        static char Menu()
        {
            Console.WriteLine("Menu >");
            Console.WriteLine("1) Add Student ");
            Console.WriteLine("2) View Student");
            Console.WriteLine("3) Top 3 Students ");
            Console.WriteLine("4) Exit");
            char op = Console.ReadLine()[0];
            return op;
        }
    }
}
