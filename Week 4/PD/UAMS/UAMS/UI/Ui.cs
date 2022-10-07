using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;

namespace UAMS.UI
{
    internal class Ui
    {
        public static Programs add_degree()
        {
            Programs input = new Programs();
            Console.Write("Enter the title of degree : ");
            input.title = Console.ReadLine();
            Console.Write("Enter Duration of the degree : ");
            input.duration = int.Parse(Console.ReadLine());
            Console.Write("Enter the Seats : ");
            input.seats = int.Parse(Console.ReadLine());
            Console.Write("Enter number of subjects : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Subjects input_subject = new Subjects();
                Console.Write("Enter the Subject Code : ");
                input_subject.code = Console.ReadLine();
                Console.Write("Enter Credit hours of the subject : ");
                input_subject.credit_hours = int.Parse(Console.ReadLine());
                Console.Write("Enter the type of subject : ");
                input_subject.type = Console.ReadLine();
                Console.Write("Enter fee of the subject : ");
                input_subject.fee = int.Parse(Console.ReadLine());
                input.subjects.Add(input_subject);
            }
            return input;
        }
        public static void specific_degree()
        {
            Console.WriteLine("Enter the name of Degree : ");
            string str = Console.ReadLine();
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            for (int i = 0; i <Crud_students.students.Count; i++)
            {
                if(Crud_students.students[i].program.title==str)
                {
                    Console.WriteLine(Crud_students.students[i].name + "\t" + Crud_students.students[i].fsc + "\t" + Crud_students.students[i].ecat + "\t" + Crud_students.students[i].age);
                }
            }
        }
        public static Student add_student()
        {
            Student input = new Student();
            Console.Write("Enter the name of student : ");
            input.name = Console.ReadLine();
            Console.Write("Enter Student age : ");
            input.age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student fsc marks : ");
            input.fsc = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat marks : ");
            input.ecat = float.Parse(Console.ReadLine());
            Console.Write("Enter number of prefrences : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num;)
            {
                Console.Write("Enter Prefrence : ");
                string str = Console.ReadLine();
                int index = Crud_students.check_program(Crud_Program.offered_degrees, str);
                if (index != -1)
                {
                    input.preference.Add(Crud_Program.offered_degrees[index]);
                    i++;
                }
            }
            input.merit = input.cal_merit();
            return input;
        }
        public static void generate_merit()
        {
            List <Student> sorted_list = Crud_students.sort_students();
            foreach(Student s in sorted_list)
            {
                foreach(Programs d in s.preference)
                {
                    if(d.seats > 0 && s.program ==null)
                    {
                        s.program = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
        public static void display_registered()
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            for (int i = 0; i < Crud_students.students.Count; i++)
            {
                if (Crud_students.students[i].program != null)
                {
                    Console.WriteLine(Crud_students.students[i].name + "\t" + Crud_students.students[i].fsc + "\t" + Crud_students.students[i].ecat + "\t" + Crud_students.students[i].age);
                }
            }
        }
        public static void register_subjects()
        {
            Console.WriteLine("Enter the name of Student : ");
            string str = Console.ReadLine();
            Console.Write("Enter the code of subject : ");
            string str2 = Console.ReadLine();
            for (int i = 0; i < Crud_students.students.Count; i++)
            {
                if (Crud_students.students[i].program != null && str == Crud_students.students[i].name)
                {
                    bool check = false;
                    for (int m = 0; m < 10; m++)
                    {
                        if (str2 == Crud_students.students[i].program.subjects[m].code)
                        {
                            Crud_students.students[i].subjects.Add(Crud_students.students[i].program.subjects[m]);
                            Console.WriteLine("Registered...");
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        Console.WriteLine("Code does not exists.");
                    }
                }
            }
        }
        public static void display_fee()
        {
            Console.WriteLine("Name\tFee");
            for (int i = 0; i < Crud_students.students.Count; i++)
            {
                if (Crud_students.students[i].program != null)
                {
                    Console.WriteLine(Crud_students.students[i].name + "\t" + Crud_students.students[i].fee);
                }
            }
        }
        public static void header()
        {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("                UAMS                 ");
            Console.WriteLine("*************************************");
            Console.WriteLine("");
        }
        public static char menu()
        {
            Console.WriteLine("1)  Add Student ");
            Console.WriteLine("2)  Add Degree Program ");
            Console.WriteLine("3)  Generate Merit ");
            Console.WriteLine("4)  View Registered Students ");
            Console.WriteLine("5)  View Students of a specific Program ");
            Console.WriteLine("6)  Register Subject for a specific Student ");
            Console.WriteLine("7)  Calculate fee of All registered Students ");
            Console.WriteLine("8)  EXIT ");
            Console.Write("Enter Your Option ...");
            char op = Console.ReadLine()[0];
            return op;
        }
        public void registersubject(Student s)
        {
            Console.Write("Enter number of subjects : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the subjecet Code : ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(Subjects subjects in s.program.subjects)
                {
                    if(code == subjects.code && !(s.subjects.Contains(subjects)))
                    {
                        s.regStudent_subject(subjects);
                        flag = true;
                        break;
                    }
                }
                if(!flag)
                {
                    Console.WriteLine("Enter valid course .");
                    i--;
                }
            }
        }
    }
}
