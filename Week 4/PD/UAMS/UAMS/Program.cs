using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
using UAMS.UI;
namespace UAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Ui.header();
                char option=Ui.menu();
                Ui.header();
                if(option=='1')
                {
                    Crud_students.students.Add(Ui.add_student());
                }
                else if( option == '2')
                {
                    Crud_Program.offered_degrees.Add(Ui.add_degree());
                }
                else if(option == '3')
                {
                    Ui.generate_merit();
                }
                else if(option =='4')
                {
                    Ui.display_registered();
                }
                else if(option=='5')
                {
                    Ui.specific_degree();
                }
                else if(option =='6')
                {
                    Ui.register_subjects();
                }
                else if(option=='7')
                {
                    Crud_students.fee_generation();
                    Ui.display_fee();
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}
