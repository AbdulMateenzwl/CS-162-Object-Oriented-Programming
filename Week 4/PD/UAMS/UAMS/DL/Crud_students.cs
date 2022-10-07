using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS.DL
{
    internal class Crud_students
    {
        public static List<Student> students = new List<Student>();
        
        public static int check_program(List<Programs> offered_degrees, string str)
        {
            for (int w = 0; w < offered_degrees.Count; w++)
            {
                if (offered_degrees[w].title == str)
                {
                    return w;
                }
            }
            return -1;
        }
        public static void fee_generation()
        {
            foreach(Student s in students)
            {
                if(s.program !=  null)
                {
                    Console.Write(s.name + " has " + s.cal_fee() + " fees .");
                }
            }
        }

        public Student student_present(string name)
        {
            foreach(Student student in students)
            {
                if(name==student.name && student.program != null)
                {
                    return student;
                }
            }
            return null;
        }
        public static List<Student> sort_students()
        {
            List<Student> sorted_students = new List<Student>();
            foreach(Student s in students)
            {
                s.cal_merit();
            }
            sorted_students= students.OrderByDescending(o =>o.merit).ToList();
            return sorted_students;
        }
    }
}
